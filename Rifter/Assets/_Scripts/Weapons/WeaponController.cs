using System;
using System.Collections;
using _Scriptable_Objects;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace _Scripts.Weapons
{

    [RequireComponent(typeof(SpriteRenderer))]
    public class WeaponController : SystemManager
    {
        private int _ammo;
        private bool _isShooting = false;
        private Vector3 _aimScreenWorldPosition;

        [SerializeField] protected GameObject projectileDirection; 
        [SerializeField] private SOWeaponData soWeaponData;
        [SerializeField] private GameObject bullet;
        [SerializeField] private Transform bulletDirection;
        [SerializeField] protected SpriteRenderer weaponRenderer;
        [SerializeField] protected bool reloadCoroutine = false;

        //Unity Events
        
        [field: SerializeField] private UnityEvent OnShoot { get; set; }
        [field: SerializeField] private UnityEvent OnShootNoAmmo { get; set; }
        [field: SerializeField] private UnityEvent OnReload { get; set; }

        private int Ammo
        {
            get => _ammo;
            set => _ammo = Mathf.Clamp(value, 0, soWeaponData.AmmoCapacity);
        }

        private void Awake()
        {
            weaponRenderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            Ammo = soWeaponData.AmmoCapacity;
            var input = GetInput;
            input.PlayerControls.Reload.performed += _ => Reload();
            input.PlayerControls.AttackStart.performed += _ => AttackPressed();
            input.PlayerControls.AttackFinnish.performed += _ => AttackReleased();
        }
        
        private void Update()
        {
            _aimScreenWorldPosition = SystemManager.GetMousePosition;
            PlayerAim(_aimScreenWorldPosition);
            PlayerShoot();
        }

        private void PlayerAim(Vector3 aimWorldPosition)
        {
            //Rotation
            var targetDirection = aimWorldPosition - transform.position;
            var angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        }

        private void PlayerShoot()
        {
            
            if (_isShooting && reloadCoroutine == false)
            {
                if (Ammo > 0)
                {
                    
                    OnShoot?.Invoke();
                    Ammo--;
                    Debug.Log("Shots lefts " + Ammo);
                    
                    for (var i = 0; i < soWeaponData.GetBulletCountToSpawn(); i++)
                    {
                        ShootBullet();
                    }
                }
                else
                {
                    _isShooting = false;
                    OnShootNoAmmo?.Invoke();
                }
                
                StartCoroutine(DelayNextShoot());
                if (soWeaponData.AutomaticFire == false)
                {
                    _isShooting = false;
                }
            }
        }

        private void AttackPressed()
        {
            _isShooting = true;
        }

        private void AttackReleased()
        {
            _isShooting = false; 
        }

        private IEnumerator DelayNextShoot()
        {
            reloadCoroutine = true;
            yield return new WaitForSeconds(soWeaponData.WeaponDelay);
            reloadCoroutine = false;
        }

        private void Reload()
        {
            if (Ammo < soWeaponData.AmmoCapacity)
            {
                OnReload?.Invoke();
                Ammo += soWeaponData.AmmoCapacity - Ammo;
                StartCoroutine(DelayNextShoot());
                Debug.Log("Reloaded ");
            }
        }
        
        private void ShootBullet()
        {
            SpawnBullet(projectileDirection.transform.position, CalculateAngle(projectileDirection));
        }

        private void SpawnBullet(Vector3 position, Quaternion rotation)
        {
            var projectilePrPrefab = Instantiate(soWeaponData.ProjectileData.ProjectilePrefab, position, rotation);
            projectilePrPrefab.GetComponent<Projectile>().ProjectileData = soWeaponData.ProjectileData;
        }

        private Quaternion CalculateAngle(GameObject direction)
        {
            float spread = Random.Range(-soWeaponData.SpreadAngle, soWeaponData.SpreadAngle);
            Quaternion bulletSpreadRotation = Quaternion.Euler(new Vector3(0, 0, spread));
            return direction.transform.rotation * bulletSpreadRotation;
        }
    }
}

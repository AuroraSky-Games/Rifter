using System;
using System.Collections;
using _Scriptable_Objects;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace _Scripts.Weapons
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class WeaponController : MonoBehaviour
    {
        private GameInput _input;
        private Camera _main;
        private int _ammo;
        private bool _isShooting = false;

        [SerializeField] protected GameObject projectileDirection; 
        [SerializeField] private SOWeaponData soWeaponData;
        [SerializeField] private GameObject bullet;
        [SerializeField] private Transform bulletDirection;
        [SerializeField] protected SpriteRenderer weaponRenderer;
        [SerializeField] protected bool reloadCoroutine = false;

        //Unity Events
        
        [SerializeField] public UnityEvent OnShoot { get; set; }
        [SerializeField] public UnityEvent OnShootNoAmmo { get; set; }

        private int Ammo
        {
            get => _ammo;
            set => _ammo = Mathf.Clamp(value, 0, soWeaponData.AmmoCapacity);
        }

        private void OnEnable()
        {
            _input.Enable();
        }

        private void OnDisable()
        {
            _input.Disable();
        }

        private void Awake()
        {
            _input = new GameInput();
            weaponRenderer = GetComponent<SpriteRenderer>();
        }
    
        private void Start()
        {
            _main = Camera.main;
            Ammo = soWeaponData.AmmoCapacity;
            //_input.PlayerControls.AttackStart.performed += _ => PlayerShoot();
            _input.PlayerControls.Reload.performed += _ => Reload();
            _input.PlayerControls.AttackStart.performed += _ => AttackPressed();
            _input.PlayerControls.AttackFinnish.performed += _ => AttackReleased();
        }
        
        private void Update()
        {
            PlayerAim();
            PlayerShoot();
        }

        private void PlayerAim()
        {
            //Rotation
            var aimScreenPosition = _input.PlayerControls.AIM.ReadValue<Vector2>();
            var aimScreenWorldPosition = _main.ScreenToWorldPoint(aimScreenPosition);
            var targetDirection = aimScreenWorldPosition - transform.position;
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

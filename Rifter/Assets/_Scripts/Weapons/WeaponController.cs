using System.Collections;
using _Scriptable_Objects;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Weapons
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class WeaponController : MonoBehaviour
    {
        private GameInput _input;
        private bool _canShoot = false;
        private Camera _main;
        private float _weaponDelay;
        private int _ammo;
        private bool _isShooting;

        [SerializeField] protected GameObject muzzle; 
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

        private float WeaponDelay
        {
            get => _weaponDelay;
            set => _weaponDelay = Mathf.Clamp(value, 0, soWeaponData.WeaponDelay);
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
            WeaponDelay = soWeaponData.WeaponDelay;
            _input.PlayerControls.Attack.performed += _ => PlayerShoot();
            _input.PlayerControls.Reload.performed += _ => Reload();
        }
        
        private void Update()
        {
            PlayerAim();
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
            if (CanShoot() == true && ((_isShooting && reloadCoroutine) == false))
            {

                _isShooting = true;
                
                OnShoot?.Invoke();

                for (var i = 0; i < soWeaponData.GetBulletCountToSpawn(); i++)
                {
                    if (CanShoot() == true)
                    {
                        ShootBullet();
                        Ammo--;
                        Debug.Log("Shots lefts " + Ammo);
                    }

                }

                _isShooting = false;
                
                StartCoroutine(DelayNextShoot());
                
            }
            else
            {
                OnShootNoAmmo?.Invoke();
            }
        }

        private IEnumerator DelayNextShoot()
        {
            yield return new WaitForSeconds(WeaponDelay);
        }

        // private void ShootBullet()
        // {
        //     var shot = Instantiate(bullet, bulletDirection.position, bulletDirection.rotation);
        //     shot.SetActive(true);
        // }

        private bool CanShoot()
        {
            if (Ammo >  0)
            {
                return _canShoot = true;
            }
            else
            {
                return _canShoot = false;
            }
        }

        private void IsAutomatic()
        {
            if(soWeaponData){}
        }

        private void Reload()
        {
            if (Ammo < soWeaponData.AmmoCapacity)
            {
                reloadCoroutine = true;
                Ammo += soWeaponData.AmmoCapacity - Ammo;
                StartCoroutine(DelayNextShoot());
                reloadCoroutine = false;
                Debug.Log("Reloaded ");
            }
        }
        
        // Example

        private void ShootBullet()
        {
            SpawnBullet(muzzle.transform.position, CalculateAngle(muzzle));
        }

        private void SpawnBullet(Vector3 position, Quaternion rotation)
        {
            var projectilePrPrefab = Instantiate(soWeaponData.ProjectileData.ProjectilePrefab, position, rotation);
            projectilePrPrefab.GetComponent<Projectile>().ProjectileData = soWeaponData.ProjectileData;
        }

        private Quaternion CalculateAngle(GameObject muzzle)
        {
            float spread = Random.Range(-soWeaponData.SpreadAngle, soWeaponData.SpreadAngle);
            Quaternion bulletSpreadRotation = Quaternion.Euler(new Vector3(0, 0, spread));
            return muzzle.transform.rotation * bulletSpreadRotation;
        }
    }
}

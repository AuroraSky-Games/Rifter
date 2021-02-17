using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace _Scripts.Weapons
{
    public class WeaponController : MonoBehaviour
    {
        private GameInput _input;
        private bool _canShoot = true;
        private Camera _main;
    
        [SerializeField] private GameObject bullet;
        [SerializeField] private Transform bulletDirection;
        [SerializeField] private float shotTimeSpace = 2f;
        [SerializeField] protected SpriteRenderer weaponRenderer;
        [SerializeField] protected int loadedAmmo = 10;
        [SerializeField] protected bool reloadCoroutine = false;
        [SerializeField] public UnityEvent OnShoot { get; set; }
        [SerializeField] public UnityEvent OnShootNoAmmo { get; set; }

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
            _input.PlayerControls.Attack.performed += _ => PlayerShoot();
            _input.PlayerControls.Reload.performed += _ => Reload();
        }

        private void PlayerShoot()
        {
            if(!_canShoot) return;
        
            var mousePosition = _input.PlayerControls.AIM.ReadValue<Vector2>();
            mousePosition = _main.ScreenToWorldPoint(mousePosition);
            var shot = Instantiate(bullet, bulletDirection.position, bulletDirection.rotation);
            shot.SetActive(true);
            StartCoroutine(CanShoot());
         
        }

        private IEnumerator CanShoot()
        {
            loadedAmmo = loadedAmmo - 1;
            Debug.Log("Shots lefts " + loadedAmmo);
            _canShoot = false;
            yield return new WaitForSeconds(shotTimeSpace);
    
            if (loadedAmmo > 0)
            {
                _canShoot = true;
            }
        }

        private void Reload()
        {
            if (loadedAmmo < 10)
            {
                reloadCoroutine = true;
                loadedAmmo += 10 - loadedAmmo;
                reloadCoroutine = false;
            }
        }

        private void Update()
        {
        
            //Rotation
            var aimScreenPosition = _input.PlayerControls.AIM.ReadValue<Vector2>();
            var aimScreenWorldPosition = _main.ScreenToWorldPoint(aimScreenPosition);
            var targetDirection = aimScreenWorldPosition - transform.position;
            var angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        
            /*
        
        //In Case of Movement 
        
        //Movement
        Vector3 movement = input.PlayerControls.Movement.ReadValue<Vector2>() * moveMentVelocity;
        transform.position += movement * Time.deltaTime;
        
        */

        }
    }
}

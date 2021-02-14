using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    
    
    private GameInput input;
    private bool canShoot = true;
    private Camera main;
    
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletDirection;
    [SerializeField] private float ShotTimeSpace = 0.5f;
    [SerializeField] private float moveMentVelocity = 5;
    [SerializeField] protected SpriteRenderer weaponRenderer;
    [SerializeField] protected int ammo = 10;
    [SerializeField] protected SOWeaponData weaponData;

    public int Ammo
    {
        get { return ammo; }
        set
        {
            ammo = Mathf.Clamp(value, 1, weaponData.Ammocapacity);
        }
    }

    private void Awake()
    {
        input = new GameInput();
        weaponRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    private void Start()
    {
        main = Camera.main;
        input.PlayerControls.Attack.performed += _ => PlayerShoot();
    }

    private void PlayerShoot()
    {
        if(!canShoot) return;
        
        Vector2 mousePosition = input.PlayerControls.AIM.ReadValue<Vector2>();
        mousePosition = main.ScreenToWorldPoint(mousePosition);
        GameObject shot = Instantiate(bullet, bulletDirection.position, bulletDirection.rotation);
        shot.SetActive(true);
        StartCoroutine(CanShoot());
         
    }

    private IEnumerator CanShoot()
    {
        ammo -= 1;
        Debug.Log("Shots lefts " + ammo);
        canShoot = false;
        yield return new WaitForSeconds(ShotTimeSpace);
        
        if (ammo > 0)
        {
            canShoot = true;
        }
        
    }

    private void Update()
    {
        
        //Rotation
        Vector2 AimScreenPosition = input.PlayerControls.AIM.ReadValue<Vector2>();
        Vector3 AimScreenWorldPosition = main.ScreenToWorldPoint(AimScreenPosition);
        Vector3 targetDirection = AimScreenWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        
        /*
        
        //In Case of Movement 
        
        //Movement
        Vector3 movement = input.PlayerControls.Movement.ReadValue<Vector2>() * moveMentVelocity;
        transform.position += movement * Time.deltaTime;
        
        */

    }
}

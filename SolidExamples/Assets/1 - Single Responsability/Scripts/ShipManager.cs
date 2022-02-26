using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    [SerializeField] int _shipSpeed;
    [SerializeField] int _shipRotationSpeed;
    private int _shipEnergy;
    [SerializeField] int _maxEnergy; 
    private int _shipHealth;
    [SerializeField] int _maxHealth;
    private int _currentAmmo;
    [SerializeField] int _maxAmmo;
    
    [SerializeField] List<string> _weapons;
    [SerializeField] string _currentWeapon;
    [SerializeField] int _fireForce;
    
    void Awake()
    {
        _shipEnergy = _maxEnergy;
        _shipHealth = _maxHealth;
        _currentWeapon = _weapons[0];
        _currentAmmo = _maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //ToDo
            Shot();
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            //ToDo
            ChangeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //ToDo
            ChangeWeapon();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //ToDo
            ChangeWeapon();
        }

    }

    private void Shot()
    {
        _currentAmmo--;
    }

    private void ReciveDamage()
    {
        _shipHealth--;
    }

    private void DecreaceEnergy()
    {
        _shipEnergy--;
    }

    private void IncreaseEnergy()
    {
        _shipEnergy++;
    }    

    private void ChangeWeapon()
    {
        //ToDo
    }

    //...etc
}

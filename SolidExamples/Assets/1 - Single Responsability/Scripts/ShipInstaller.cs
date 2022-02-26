using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInstaller : MonoBehaviour
{
    [SerializeField] GameObject _ship;
    [SerializeField] int _maxHealth;
    [SerializeField] int _maxPower;
    [SerializeField] int _maxAmmo;


    private ShipHealth _shipHealth;
    private ShipPower _shipPower;
    private ShipWeapon _shipWeapon;
    private ShipAmmo _shipAmmo;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_ship);
        _shipHealth = new ShipHealth(_maxHealth);
        _shipPower = new ShipPower(_maxPower);
        _shipWeapon = new ShipWeapon();
        _shipAmmo = new ShipAmmo(_maxAmmo, _shipWeapon);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

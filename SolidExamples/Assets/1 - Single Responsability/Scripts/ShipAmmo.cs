using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAmmo
{
    private int _currentAmmo;
    private int _maxAmmo;
    private int _fireForce;
    private ShipWeapon _shipWeapon;
    public ShipAmmo(int maxAmmo, ShipWeapon shipWeapon)
    {
        _maxAmmo = maxAmmo;
        _currentAmmo = maxAmmo;
        _shipWeapon = shipWeapon;
    }

    public void Shot()
    {
        _currentAmmo--;
    }

    public void RecoverAmmo()
    {
        _currentAmmo++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAmmo
{
    private int _currentAmmo;
    private int _maxAmmo;
    private int _fireForce;
    public ShipAmmo(int maxAmmo)
    {
        _maxAmmo = maxAmmo;
        _currentAmmo = maxAmmo;
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

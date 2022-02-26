using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon
{
    private List<string> _weapon;
    private string _currentWeapon;
    public ShipWeapon()
    {
        _currentWeapon = _weapon[0];
    }

    public void ChangeWeapon(int indexWeapon)
    {
        _currentWeapon = _weapon[indexWeapon];
    }
}

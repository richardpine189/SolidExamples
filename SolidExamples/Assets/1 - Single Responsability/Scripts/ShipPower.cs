using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPower
{
    private int _shipPower;
    private int _maxPower;

    public ShipPower(int maxPower)
    {
        _shipPower = _maxPower;
    }
    private void DecreaceEnergy()
    {
        _shipPower--;
    }

    private void IncreaseEnergy()
    {
        if(_shipPower < _maxPower)
        _shipPower++;
    }
}

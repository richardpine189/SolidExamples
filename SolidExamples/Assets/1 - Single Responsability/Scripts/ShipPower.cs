using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPower
{
    private int _shipEnergy;
    private int _maxEnergy;

    public ShipPower(int maxEnergy)
    {
        _shipEnergy = _maxEnergy;
    }
    private void DecreaceEnergy()
    {
        _shipEnergy--;
    }

    private void IncreaseEnergy()
    {
        if(_shipEnergy < _maxEnergy)
        _shipEnergy++;
    }
}

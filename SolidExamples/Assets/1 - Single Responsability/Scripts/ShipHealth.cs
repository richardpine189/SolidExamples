using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth
{
    private int _maxHealth;
    private int _shipHealth;

    public ShipHealth(int maxHealth)
    {
        _maxHealth = maxHealth;
        _shipHealth = maxHealth;
    }

    public void ReciveDamage()
    {
        _shipHealth--;
    }

    public void RecoverHealth()
    {
        if(_shipHealth < _maxHealth)
            _shipHealth++;
        
    }
}

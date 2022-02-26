using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability
{
    public abstract void Process();
}

public class FireAbility : Ability
{
    public override void Process()
    {
        //ToDo
    }
}

public class HealthRecoveryAbility : Ability
{
    public override void Process()
    {
        //ToDo
    }
}

public class IceAbility : Ability
{
    public override void Process()
    {
        //ToDo
    }
}

public class AbilityFactory
{
    public Ability GetAbility(string abilityType)
    {
        switch (abilityType)
        {
            case "fire":
                return new FireAbility();
            case "ice":
                return new IceAbility();
            case "health":
                return new HealthRecoveryAbility();
            default:
                return null;
       
        }
    }

}

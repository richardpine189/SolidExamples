using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liskov;

public abstract class AnimalJumper : IAnimal
{
    public virtual void Walk()
    {
        
    }

    public abstract void Jump();
}

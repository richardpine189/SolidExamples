using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClose
{
    public abstract class Ability
    {
        public abstract string Name { get; }
        public abstract void Process();
    }
}
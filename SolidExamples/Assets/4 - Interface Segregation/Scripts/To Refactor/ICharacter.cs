using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    void UseSword();
    void UseMagic();
    void ReloadMana();
    void UseBow();
    void ReloadArrow();
    void ReloadHealth();
    void Speak();
}

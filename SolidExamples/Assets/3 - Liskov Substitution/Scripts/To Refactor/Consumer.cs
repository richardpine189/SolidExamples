using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    private Animal _animal;
    // Start is called before the first frame update
    void Start()
    {
        _animal = new Dog();
        PasTheHole(_animal);
        _animal = new Elephant();
        PasTheHole(_animal);
        //The elephan can't jump, the program throw an exception
    }

    public void PasTheHole(Animal animal)
    {
        animal.Walk();
        animal.Jump();
        _animal.Walk();
    }

}

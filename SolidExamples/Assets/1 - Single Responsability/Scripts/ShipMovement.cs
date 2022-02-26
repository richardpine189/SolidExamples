using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] int _shipSpeed;
    [SerializeField] int _shipRotationSpeed;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //ToDo
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //ToDo
        }
    }
}

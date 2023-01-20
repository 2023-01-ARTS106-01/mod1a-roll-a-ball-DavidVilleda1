using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class NewBehaviourScript : MonoBehaviour
{

Private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponets<Rigidbody>();
    }

    Void OnMove(InputValue movementValue)
    {

    Vector2 movementVector = movementValue.Get<Vector2>();

    }


    void FixedUpdate()
    {



    }



}

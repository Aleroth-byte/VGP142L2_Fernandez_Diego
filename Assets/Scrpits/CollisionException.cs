using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionException : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))  
        {
            throw new Exception("Player collided!");
        }

    }
}

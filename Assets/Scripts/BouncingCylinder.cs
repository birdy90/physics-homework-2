using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BouncingCylinder : MonoBehaviour
{
    public float ForceValue = 10f;
    
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce((collision.transform.position - transform.up) * ForceValue);
    }
}

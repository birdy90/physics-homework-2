using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BouncingPlate : MonoBehaviour
{
    public float ForceValue = 10f;
    
    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(transform.up * ForceValue);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        var tr = transform;
        var pos = tr.position;
        Gizmos.DrawLine(pos, pos + tr.up);
    }
}

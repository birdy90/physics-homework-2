using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPanel : MonoBehaviour
{
    private Vector3 _originalPosition;
    
    void Start()
    {
        _originalPosition = transform.position;
    }

    void Update()
    {
        transform.position = _originalPosition + 0.5f * Mathf.Sin(Time.time) * Vector3.left;
    }
}

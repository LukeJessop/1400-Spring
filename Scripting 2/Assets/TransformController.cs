using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public float speed = 7f;
    public float distance = 3f;
    private void Update()
    {
        var x = Mathf.PingPong(Time.time * speed, distance);
        var p = new Vector3(x, 0, 0);
        transform.position = p;
        
        transform.Rotate(new Vector3(45, 0, 0) * Time.deltaTime);
    }
}

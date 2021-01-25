using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float minSpeed = 5f;
    public float maxSpeed = 10f;
    float _speed = 1f;
    void Start()
    {
        _speed = Random.Range(minSpeed, maxSpeed);
    }
    void FixedUpdate() {
        Vector2 forward = new Vector2(transform.right.x,transform.right.y);
    }
}
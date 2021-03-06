﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleMove : MonoBehaviour
{
    [Range(0, 100)]
    public float magnitude = 1;
    [Range(0, 10)]
    public float frequency = 1;
    public bool moveRight;
    public Vector3 pos;
    [Range(0, 100)]
    public float moveSpeed;
    Vector3 nextPosition;
    Vector3 direction;

    [Range(0, 100)]
    public float rotationForce;

    bool movedRight;

    public Transform whalouTransform;

    float angle;
    // Start is called before the first frame update
    void Start()
    {
        whalouTransform = GetComponent<Transform>();
        pos = whalouTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //nextPosition = Move();
        //transform.LookAt(nextPosition);
        //direction = nextPosition - transform.position;
        //angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }

    void Move()
    {


        if (moveRight)
        {
            pos += transform.right * moveSpeed * Time.deltaTime;
            whalouTransform.position = pos + transform.up * Mathf.Sin(-Time.time * frequency) * magnitude;
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin((Time.time * frequency) - 1) * magnitude * rotationForce);


        }
        else
        {
            pos -= transform.right * moveSpeed * Time.deltaTime;
            whalouTransform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
            transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin((Time.time * frequency) - 1) * magnitude * rotationForce);


        }
        if (movedRight != moveRight)
        {
            whalouTransform.localScale *= -1;
        }
        movedRight = moveRight;

        
            
    }
}

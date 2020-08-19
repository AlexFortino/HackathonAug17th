﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class guns : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movespeed = 5f;

    public Camera cam;

    Vector2 mousePos;
    

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame

    void Update()
    {



       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        
      
    }

    void FixedUpdate()
    {


        Vector2 lookDir = mousePos - rb.position;

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = angle;
    }
}
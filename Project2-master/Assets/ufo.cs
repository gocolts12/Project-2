﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update ()
{
    transform.Rotate (0,0,45*Time.deltaTime); //rotates 45 degrees per second around z axis
}
}

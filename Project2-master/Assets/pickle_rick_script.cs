﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickle_rick_script : MonoBehaviour
{
    public AudioSource audio1;

    // Start is called before the first frame update
    void Start()
    {
        audio1.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider box)
    {
        audio1.Play();
    }
    void OnTriggerExit(Collider other)
    {
        audio1.Stop();
    }
}

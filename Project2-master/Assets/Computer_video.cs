using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer_video : MonoBehaviour
{
    public GameObject Video1;
    // Start is called before the first frame update
    void Start()
    {
        Video1 = GameObject.Find("vid1");
        Video1.active = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider box)
    {
        Video1.active = true;

    }
}

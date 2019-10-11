using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laptop_video : MonoBehaviour
{
    public GameObject Video2;

    // Start is called before the first frame update
    void Start()
    {
        Video2 = GameObject.Find("laptop_video");
        Video2.active = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider box)
    {
        Video2.active = true;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lysol_can_script : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider box)
    {
        audio.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lysol_can_script : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
            audio.Play();
    }

    void OnTriggerExit(Collider other)
    {
        audio.Stop();
    }
}

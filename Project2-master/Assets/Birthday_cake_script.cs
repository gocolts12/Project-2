using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday_cake_script : MonoBehaviour
{
    public AudioSource audio2;

    void OnTriggerEnter(Collider box)
    {
        audio2.Play();
    }
    void OnTriggerExit(Collider other)
    {
        audio2.Stop();
    }
}

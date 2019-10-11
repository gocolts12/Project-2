using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lysol_can_script : MonoBehaviour
{
    public AudioSource audio;

    void OnTriggerEnter(Collider other)
    {
        audio.Play();
    }

    void OnTriggerExit(Collider other)
    {
        audio.Stop();
    }
}

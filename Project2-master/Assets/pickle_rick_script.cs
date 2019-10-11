using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickle_rick_script : MonoBehaviour
{
    public AudioSource audio1;

    void OnTriggerEnter(Collider box)
    {
        audio1.Play();
    }
    void OnTriggerExit(Collider other)
    {
        audio1.Stop();
    }
}

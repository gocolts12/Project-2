using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED_script : MonoBehaviour
{
    public GameObject LED;

    // Start is called before the first frame update
    void Start()
    {
        //while (1 == 1)
        //{
            //StartCoroutine(toggleLED());
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator toggleLED()
    {
            LED.SetActive(true);
            yield return new WaitForSeconds(1);
            LED.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {

    private AudioSource audioData;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "FPSController")
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);

        }
    }

}

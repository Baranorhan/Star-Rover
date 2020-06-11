using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOn : MonoBehaviour {

    public AudioClip saw;    // Add your Audi Clip Here;
                             // This Will Configure the  AudioSource Component; 
                             // MAke Sure You added AudioSouce to death Zone;
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;
    }

     void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().Play();
    }
    
}

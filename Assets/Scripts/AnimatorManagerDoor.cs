using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManagerDoor : MonoBehaviour {
    //public GameObject door;
    public Animator ani;
    public AudioClip sound;
	// Use this for initialization
	void Start () {
        ani.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        ani.enabled = true;        
    }
}

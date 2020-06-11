using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetory : MonoBehaviour {
    public static int charge = 0;
    public AudioClip collectedSound;

	// Use this for initialization
	void Start () {
        charge = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InventoryPickup(int inventory)
    {
        AudioSource.PlayClipAtPoint(collectedSound, transform.position);
        charge++;
    }
}

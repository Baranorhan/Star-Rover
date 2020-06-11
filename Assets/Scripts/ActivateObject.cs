using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour {
    // public GameObject minimap;
    int timer = 0;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        timer++;
        if (timer == 30)
        {
            gameObject.SetActive(true);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone_Temp : MonoBehaviour {
    public GameObject gObject;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other)
    {
        gObject.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        gObject.SetActive(false);
    }
}

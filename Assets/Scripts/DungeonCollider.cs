using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonCollider : MonoBehaviour {

    public GameObject dummy;
    Collider colOther;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnCollisionHit()
    {

    }

     void OnTriggerEnter(Collider other)
    {
      other.transform.SetParent(gameObject.transform);
    }

    void OnTriggerExit(Collider other)
    {
        transform.SetParent(dummy.transform);
    }

    






}

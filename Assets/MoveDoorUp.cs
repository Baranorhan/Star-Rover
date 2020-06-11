using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDoorUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Girdi");
            StartCoroutine(MoveUp());
        }
    }

    IEnumerator MoveUp()
    {
         for(int i=0; i<15; i++)
        {
         transform.position += Vector3.up;
         yield return new WaitForSeconds(.3f);
        }
        
    }
}

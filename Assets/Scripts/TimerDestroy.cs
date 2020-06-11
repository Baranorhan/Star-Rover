using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy  : MonoBehaviour {
  
    Rigidbody rb;
    int count = 1;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(1);
        rb.useGravity = true;
        rb.isKinematic = false;

    }
    
    void OnTriggerEnter(Collider other)
    {
        
        if(count ==1)
        {
            StartCoroutine("ExecuteAfterTime");
            count++;
        }
    }


}

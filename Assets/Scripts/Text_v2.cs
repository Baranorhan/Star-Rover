using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_v2 : MonoBehaviour {

    public GameObject uiObject;
    public void Start()
    {
        uiObject.SetActive(false);        
    }

    public void OnTriggerEnter(Collider other)
    {
        
        uiObject.SetActive(true);
        StartCoroutine("WaitForSec");
        
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(uiObject);
    }
}

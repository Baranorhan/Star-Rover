using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part4TP : MonoBehaviour {

    public GameObject go;
    // Use this for initialization
   

    private void OnTriggerEnter(Collider other)

    {var playerObject = GameObject.Find("FPSController");
        

        other.transform.position = new Vector3(go.transform.position.x +playerObject.transform.position.x - this.transform.position.x, playerObject.transform.position.y, go.transform.position.z)  ;

        int counter = 0;
        var clones = GameObject.FindGameObjectsWithTag("mummy");
        foreach (var clone in clones) { clone.transform.position = new Vector3(other.transform.position.x+counter,other.transform.position.y,other.transform.position.z-10);
            counter += 5;
        }
    }
}

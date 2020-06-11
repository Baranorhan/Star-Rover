using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSParent : MonoBehaviour {
    public GameObject dummy;
    public void OnTriggerEnter(Collider other)
    {

        other.transform.SetParent(dummy.transform);

    }
}

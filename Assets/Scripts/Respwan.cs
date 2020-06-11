using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respwan : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
                    player.transform.position = RespawnPoint.transform.position;     
    }
}

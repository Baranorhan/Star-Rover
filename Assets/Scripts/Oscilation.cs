using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilation : MonoBehaviour {
    float timeCounter =0;

    float speed;
    float width;
    float height;
	// Use this for initialization
	void Start () {
        speed = 5;
        width = 4;
        height = 7;
	}
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime*speed;

        float y = Mathf.Cos(timeCounter)*width;
        float x = Mathf.Sin(timeCounter)*height;
        float z = 0;

        transform.position = new Vector3(x,y,z);
	}
}

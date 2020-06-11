using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryTrial : MonoBehaviour {
    public float rotationSpeed = 100.0f;
   // public Text textHints;

    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
	}

    void OnTriggerEnter(Collider col)
    {

        // col.gameObject.SendMessage("Inventory Pickup");
            Destroy(gameObject);

    }
}

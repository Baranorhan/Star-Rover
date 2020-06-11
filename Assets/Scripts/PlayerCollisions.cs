using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {
    private bool doorIsOpen = false;
   // private float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
   // public AudioClip doorShutSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag =="door" && doorIsOpen == false)
        {
            Debug.Log("Collided");
            OpenDoor(hit.gameObject);
        }
    }

    void OpenDoor(GameObject door)
    {
        doorIsOpen = true;
        door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
        door.transform.position = Vector3.up;
    }
}

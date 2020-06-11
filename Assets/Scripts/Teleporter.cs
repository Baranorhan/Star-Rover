using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Teleporter : MonoBehaviour {
    //public GameObject YouGameObject;
       public int ob;
    public Material mat;
    public GameObject mumies;
    public GameObject lamb;
        // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
        void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.name== "FPSController")
        {

            if (ob == 0) { 
                col.gameObject.transform.position = new Vector3(15, 2, 7);//(Start Point)
            col.SendMessage("StopALL");
            }
            else if (ob == 1)
                col.gameObject.transform.position = new Vector3(60, 10, 42);//(THIRD )

           else  if (ob == 2)
            {
                col.transform.rotation = Quaternion.Euler(0, 0, 0);
                col.gameObject.transform.position = new Vector3(58, 48, 112);//(THIRD ONE)
               
                var clones = GameObject.FindGameObjectsWithTag("clone");
                foreach (var clone in clones) { Destroy(clone); }
                var clones2 = GameObject.FindGameObjectsWithTag("lighter");
                foreach (GameObject clone in clones2) { clone.GetComponent<MeshRenderer>().material = mat; }
                lamb.SendMessage("FIRE");
                GameObject.Find("FPSController").SendMessage("StopALL");
            } 
            else if (ob == 3) {
                var clones = GameObject.FindGameObjectsWithTag("clone");
            foreach (var clone in clones) { Destroy(clone); }
            var clones2 = GameObject.FindGameObjectsWithTag("lighter");
            foreach (GameObject clone in clones2) { Destroy(clone); }
            
                col.gameObject.transform.position = new Vector3(70, 9, 231);//(where you want to teleport)
                mumies.SetActive(true);

            }
        }

    }
}

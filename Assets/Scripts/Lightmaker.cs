using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightmaker : MonoBehaviour {
    public Material NewColor;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject fire, nextLamp;
    private GameObject fire1, fire2;
    
    public int id; 

    // Use this for initialization
    void Start () {
		
       

	}
	
	// Update is called once per frame
	void Update () {

       

    }


   public void FIRE()
    {
            if (id==1)
                fire1 = Instantiate(fire, new Vector3(-30, 8, 0) + transform.position, Quaternion.identity);
            else if(id==0)
                fire1 = Instantiate(fire, new Vector3(0, 8, -20) + transform.position, Quaternion.identity);
        else if (id == 2)
            fire1 = Instantiate(fire, new Vector3(0, 8, -55) + transform.position, Quaternion.identity);
            else if(id==3)
            fire1 = Instantiate(fire, new Vector3(45, 8, 0) + transform.position, Quaternion.identity);
        else if (id ==4)
            fire1 = Instantiate(fire, new Vector3(0, 8, 35) + transform.position, Quaternion.identity);
        else if (id == 5)
            fire1 = Instantiate(fire, new Vector3(-28, 8, 0) + transform.position, Quaternion.identity);
        fire1.tag = "clone";

        fire2 = Instantiate(fire, new Vector3(0, 8, 0) + transform.position, Quaternion.identity);
        fire2.tag = "clone";
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "FPSController")
        {
            this.GetComponent<MeshRenderer>().material = NewColor;
            Destroy(fire2);
            Destroy(fire1);
            nextLamp.SendMessage("FIRE");

        }
    }

}

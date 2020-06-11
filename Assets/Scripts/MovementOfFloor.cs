using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfFloor : MonoBehaviour {
   
    
    public Transform start;
    public  Transform end;
    public float increase=0.01f;
    float counter = 0;
    bool increasing = true;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (counter <= 0)
        {
            increasing = true;
            counter = 0;
        }
        else if(counter>=1)
        {
            increasing = false;
            counter = 1;
        }

       
        if (counter <= 1 && increasing)
        {
            counter = counter + increase;
      
        }

        if (counter <= 1 && !increasing)
        {
  
            counter = counter - increase;
        }
        transform.position = Vector3.Lerp(start.position, end.position, counter);
    }
}

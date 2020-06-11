using UnityEngine;

public class cursor : MonoBehaviour
{
    private GameObject other;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    void Update()
    {
        //Cursor.visible = true;
       
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            // OPEN WHEN NOT DEMO
            Cursor.lockState = CursorLockMode.None;
      }
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "mummy")
            {            
             other = GameObject.Find("FPSController");
               other.SendMessage("StopALL");


                other.gameObject.transform.position = new Vector3(70, 9, 231);
         
                int counter = 0;
            var clones = GameObject.FindGameObjectsWithTag("mummy");
                foreach (var clone in clones)
                {
                clone.transform.position = new Vector3(65+counter,0,204);
                counter += 5; 
                }
                other.transform.rotation = Quaternion.Euler(0, 0, 0);
                other.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().mouseReset();
            }
        }

    }
}

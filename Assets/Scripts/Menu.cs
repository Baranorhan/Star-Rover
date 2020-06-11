using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
    public GameObject CanvasObject;

    // Use this for initialization
    void Start () {
          
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            StopALL();
        
    }

     public void StopALL()
        {
        Time.timeScale = 0;
        CanvasObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        GetComponent<cursor>().enabled = false;
        GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
        AudioListener.volume = 0f;       
     }
    public void ResumeAll()
    {
        Time.timeScale = 1;
        CanvasObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        GetComponent<cursor>().enabled = true;
        GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
        AudioListener.volume = 1f;
        GameObject.Find("follow").transform.rotation = Quaternion.Euler(0, 0, 0);
        
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}

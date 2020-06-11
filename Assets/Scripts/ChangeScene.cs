using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    [SerializeField] private string loadLevel;
    
  
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("ChangeScene");
        SceneManager.LoadScene(loadLevel);
    }

   
}

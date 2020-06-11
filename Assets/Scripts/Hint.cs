using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hint : MonoBehaviour {
    public Text textHints;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Deneme");
        textHints.SendMessage("ShowHint", "DDDDDD");
    }
}

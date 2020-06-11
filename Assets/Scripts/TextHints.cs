using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHints : MonoBehaviour {

    void ShowHint(string message)
    {
        GetComponent<Text>().text = message;
        if(!GetComponent<Text>().enabled)
        {
            GetComponent<Text>().enabled = true;
        }
    }
}

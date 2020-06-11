using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Buttons : MonoBehaviour {
    private AudioSource audioData;
    public Sprite[] charges;
    public Image[] images;
    int[] count = new int[]{ 0, 0, 0, 0, 0 };
                int[] ans = new int[] { 0, 6, 5, 4, 3 };

    public Animator anim;
	 
   public void Imagechange(int t)
    {

        if (count[t] == 7)
            count[t] = -1;
            images[t].sprite = charges[++count[t]];
   
       for(int a = 0; a < count.Length; a++)
        {
            if (count[a] != ans[a])
                break;
            if (a == 4) { 
                Debug.Log("works");
                anim.Play("lock");
                audioData = GetComponent<AudioSource>();
                audioData.Play(0);

            }
                

        }
    }
}

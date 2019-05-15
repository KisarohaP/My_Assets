using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumCan : MonoBehaviour {

    public int point = 1;
    private int Frag;
        
    // Use this for initialization
    void OnCollisionEnter(Collision o) {
        if(o.gameObject.tag == "Tar")
        {
            Destroy(o.gameObject);
            Debug.Log("Hit!");
            Frag = PlayerPrefs.GetInt("Frg")+1;
            PlayerPrefs.SetInt("Frg", Frag);
        }
    }
}

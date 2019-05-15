using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadContorller : MonoBehaviour {
    public float HeadRotate;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, HeadRotate, 0);
            //transform.RotateAround(new Vector3(0, 5.5f, 6), transform.up, HeadRotate*Time.deltatime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -HeadRotate, 0);
            //transform.RotateAround(new Vector3(0, 5.5f, 6), transform.up, HeadRotate*Time.deltatime);
        }
    }
}

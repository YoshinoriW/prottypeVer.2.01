using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensController : MonoBehaviour {

    
    public float moveSpeed;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.Translate(-0.05f*moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.Translate(0, -0.05f*moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.Translate(0.05f*moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.Translate(0, 0.05f*moveSpeed, 0);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTouchingCircle : MonoBehaviour {

    public static bool completeSphere = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "MovingSphere"))
        {
            completeSphere = true;
            Debug.Log("Complete Sphere");
        }


    }
}

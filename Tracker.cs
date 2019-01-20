using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tracker : MonoBehaviour {
    public bool isComplete = false;
    public bool done = false;
    public GameObject textHolder;
    public GameObject doorTransport;
	// Use this for initialization
	void Start () {
        doorTransport.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (isTouchingCapsule.completeCapsule && isTouchingCircle.completeSphere && isTouchingCylinder.completeCylinder && isTouchingcube.completeCube)
        {
            Debug.Log("done");
            isTouchingCapsule.completeCapsule = false;
            isTouchingCircle.completeSphere = false;
            isTouchingCylinder.completeCylinder = false;
            isTouchingcube.completeCube = false;
            done = true;


        }
        if (done)
        {
           textHolder.GetComponent<TextMesh>().text =  "Stage Complete! Please continue to the next stage";
            doorTransport.SetActive(true);
            this.gameObject.SetActive(false);
        }
	}

   
}

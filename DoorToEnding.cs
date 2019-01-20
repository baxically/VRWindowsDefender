using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToEnding : MonoBehaviour {

    public GameObject windowDoor;
    public GameObject player;
    public bool done = false;
	void Start () {
        windowDoor.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (BlackBox.isGreen && BlackBox2.isPurple && BlackBox3.isOrange)
        {
            Debug.Log("Complete");
            BlackBox.isGreen = false;
             BlackBox2.isPurple = false;
            BlackBox3.isOrange = false;
            done = true;
           
        }
        
        if (done)
        {
            windowDoor.SetActive(true);
            this.gameObject.SetActive(false);
        }
	}


 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnding : MonoBehaviour {

    public GameObject player;
    public GameObject endingText;
    public GameObject window;
    public GameObject sphere;
    // Use this for initialization
    void Start () {
        endingText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(TransformPos())
        {

            player.transform.position = sphere.transform.position;
            this.endingText.SetActive(true);
            this.gameObject.SetActive(false);


        }
	}




        bool TransformPos()
    {
        return player.transform.position.z > window.transform.position.z;

    }

}

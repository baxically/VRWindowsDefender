using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransport : MonoBehaviour {
    public GameObject player;
    public GameObject textInstructions;
    public GameObject greenText;
    public GameObject purpleText;
    public GameObject orangeText;

    // Use this for initialization
    void Start () {
        textInstructions.SetActive(false);
        greenText.SetActive(false);
        purpleText.SetActive(false);
        orangeText.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (TransformPos())
        {
            player.transform.position = new Vector3(0f, -20f, 320f);
            this.gameObject.SetActive(false);
            textInstructions.SetActive(true);
            greenText.SetActive(true);
            purpleText.SetActive(true);
            orangeText.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }


    bool TransformPos()
    {
        return player.transform.position.z > 238;
    }
}


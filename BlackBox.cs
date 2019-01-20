using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBox : MonoBehaviour {

    public static bool isGreen = false;
    public static bool isBlueTouched = false;
    public static bool isYellowTouched = false;
    public GameObject block;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Blue Cube 1" || collision.gameObject.name == "Blue Cube 2" || collision.gameObject.name == "Blue Cube 3")
        {
            isBlueTouched = true;
            Debug.Log("Is Blue Touched");
        }

        if (collision.gameObject.name == "Yellow Cube 1" || collision.gameObject.name == "Yellow Cube 2" || collision.gameObject.name == "Yellow Cube 3")
        {
            isYellowTouched = true;
            Debug.Log("Is Yellow Touched");
        }

        if (isBlueTouched && isYellowTouched)
        {
           block.gameObject.GetComponent<Renderer>().material.color = Color.green;
            isGreen = true;
        }


       
    }
}

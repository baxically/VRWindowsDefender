using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBox2 : MonoBehaviour {

    public static bool isPurple = false;
    public static bool isBlueTouched = false;
    public static bool isRedTouched = false;
    public GameObject block;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Blue Cube 1" || collision.gameObject.name == "Blue Cube 2" || collision.gameObject.name == "Blue Cube 3")
        {
            isBlueTouched = true;
            Debug.Log("Is Blue Touched");
        }

        if (collision.gameObject.name == "Red Cube 1" || collision.gameObject.name == "Red Cube 2" || collision.gameObject.name == "Red Cube 3")
        {
            isRedTouched = true;
            Debug.Log("Is Red Touched");
        }

        if (isBlueTouched && isRedTouched)
        {
            block.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            isPurple = true;
        }


    }
}

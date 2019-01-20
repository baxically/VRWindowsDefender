using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBox3 : MonoBehaviour {

    public static bool isOrange = false;
    public static bool isRedTouched = false;
    public static bool isYellowTouched = false;
    public Color orange = new Color(1.0f, 165/255f, 0);
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
        if (collision.gameObject.name == "Yellow Cube 1" || collision.gameObject.name == "Yellow Cube 2" || collision.gameObject.name == "Yellow Cube 3")
        {
            isYellowTouched = true;
            Debug.Log("Is Yellow Touched");
        }

        if (collision.gameObject.name == "Red Cube 1" || collision.gameObject.name == "Red Cube 2" || collision.gameObject.name == "Red Cube 3")
        {
            isRedTouched = true;
            Debug.Log("Is Red Touched");
        }

        if (isYellowTouched && isRedTouched)
        {
            block.gameObject.GetComponent<Renderer>().material.color = orange;
            isOrange = true;


        }


    }

}

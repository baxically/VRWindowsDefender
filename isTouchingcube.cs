using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class isTouchingcube : MonoBehaviour
{

    public static bool completeCube = false;
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
        if ((collision.gameObject.name == "MovingCube"))
        {
            completeCube = true;
            Debug.Log("Complete Cube");
        }


    }
}

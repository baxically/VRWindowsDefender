using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTouchingCylinder : MonoBehaviour
{

    public static bool completeCylinder = false;
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
        if ((collision.gameObject.name == "MovingCylinder"))
        {
            completeCylinder = true;
            Debug.Log("Complete Cylinder");
        }


    }
}

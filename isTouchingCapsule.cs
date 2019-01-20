using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTouchingCapsule : MonoBehaviour
{

    public static bool completeCapsule = false;
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
        if ((collision.gameObject.name == "MovingCapsule"))
        {
            completeCapsule = true;
            Debug.Log("Complete Capsule");
        }


    }
}

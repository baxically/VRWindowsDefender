using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouching : MonoBehaviour {

    private int countTutorial = 0;
    public bool[] myObjects = new bool[4];
    private bool cubeValue = false;
    private bool cylinderValue = false;
    private bool sphereValue = false;
    private bool capsuleValue = false;
    public void Start()
    {
        myObjects[0] = cubeValue; //0
        myObjects[1] = cylinderValue; //1
        myObjects[2] = sphereValue;//2
        myObjects[3] = capsuleValue;//3
    }

    void Update()
    {
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MovingCube")
        {         
          
                this.myObjects[0] = true;
                Debug.Log("Complete Cube");
        }
        
        if (collision.gameObject.name == "MovingCylinder")
        {

                this.myObjects[1] = true;
              
            Debug.Log("Complete Cylinder");
        }
        
        if ((collision.gameObject.name == "MovingSphere") && !(this.myObjects[2]))
        {
             this.myObjects[2] = true;
            Debug.Log("Complete Sphere");
        }
        
        if (collision.gameObject.name == "MovingCapsule")
        {
           this. myObjects[3] = true;
            Debug.Log("Complete Capsule");
        }

        for (int i = 0; i < this.myObjects.Length; i++)
        {
            if (!this.myObjects[i])
            {
                return;
            }
        }
        Debug.Log("done");


    }
}

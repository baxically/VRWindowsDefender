using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject textName;
    public static bool teleport = false;
    // Use this for initialization
    void Start()
    {
        this.textName.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.Get(OVRInput.Button.Two)) || (OVRInput.Get(OVRInput.Button.Four)) && teleport)
        {
            Player.gameObject.transform.position = new Vector3(0, -23f, 200f);
            teleport = false;
            this.textName.SetActive(true);
        }
    }
}


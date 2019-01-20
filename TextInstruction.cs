using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextInstruction : MonoBehaviour
{

    public GameObject text;
    public static bool setTextOn = false;

    // Use this for initialization
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (setTextOn)
        {
            text.SetActive(true);
        }
    }
}

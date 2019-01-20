using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom : MonoBehaviour {
    public GameObject player;
    public GameObject PlayerText;

    // Use this for initialization
    void Start () {
        PlayerText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (TransformPos())
        {
            player.transform.position = new Vector3(0f, -23f, 110f);
            this.gameObject.SetActive(false);
            this.PlayerText.SetActive(true);
            PressButton.teleport = true;

        }
	}

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
    }
    bool TransformPos()
    {
        
        return player.transform.position.z > 7;
    } 

}

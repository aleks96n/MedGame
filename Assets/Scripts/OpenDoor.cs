using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {


    private Animation animation;
	// Use this for initialization
	void Start () {
        animation = gameObject.GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("touched");
        animation.Play("DoorOpen");

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnActor : MonoBehaviour {

    public Transform target;
    private Animation anim;
    private bool clickedON = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if (clickedON)
        {
            var speed = 5;
            //Debug.Log("I got clicked");
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            anim.Play("moveAnimation");
        }
    }

    void OnMouseDown()
    {
        clickedON = true;
    }
}

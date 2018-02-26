using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnActor : MonoBehaviour {

    public List<Transform> target = new List<Transform>();


    private Animation anim;
    private Animation doorAnimation;
    private bool clickedON = false;
    public GameObject border;
    private SceneSwitcherScript sceneSwitcher;
    private int i = 0;
    private bool doorOpened = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
        doorAnimation = GameObject.FindGameObjectWithTag("Door").GetComponent<Animation>();
        sceneSwitcher = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneSwitcherScript>();

    }
	
	// Update is called once per frame
	void Update () {
        if (clickedON)
        {
            if (!doorOpened)
            {
                doorAnimation.Play("doorOpen");
                doorOpened = true;
            }
            if (i == 3)
            {
                clickedON = false;
            }
            
            //Debug.Log("I got clicked");
            else if (transform.position == target[i].transform.position)
            {
                Debug.Log("got here");
                i++;
            }
            else
            {
                if(i == 1)
                {
                    sceneSwitcher.turnOnRightCamera("second");
                    gameObject.layer = 10;
                }
                var speed = 5;
                Debug.Log(target[i]);
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target[i].position, step);
            }
           
            anim.Play("moveAnimation");
            
        }
    }

    void OnMouseDown()
    {
        clickedON = true;
    }

    void OnMouseOver()
    {
        border.SetActive(true);
    }

    void OnMouseExit()
    {
        border.SetActive(false);
    }
}

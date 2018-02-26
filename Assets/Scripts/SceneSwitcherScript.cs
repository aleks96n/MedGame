using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcherScript : MonoBehaviour {
    public GameObject firstTransition;
    public GameObject secondTransition;
    private GameObject lastEnabledCamera;
	// Use this for initialization
	void Start () {
        lastEnabledCamera = firstTransition;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void turnOnRightCamera(string whichCamera)
    {
        switch (whichCamera)
        {
            case ("first"):
                lastEnabledCamera.SetActive(false);
                firstTransition.SetActive(true);
                lastEnabledCamera = firstTransition;
                break;
            case ("second"):
                lastEnabledCamera.SetActive(false);
                secondTransition.SetActive(true);
                lastEnabledCamera = secondTransition;
                break;
        }
    }
}

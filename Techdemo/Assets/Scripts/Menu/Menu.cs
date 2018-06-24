using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    bool paused;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void pause()
    {
        if (!paused)
        {
            paused = true;
            Time.timeScale = 0;
        }
    }
}


﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
	
	
	public void Close()
	{
		Application.Quit();
	}

}

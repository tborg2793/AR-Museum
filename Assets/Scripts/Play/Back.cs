using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Application.platform == RuntimePlatform.Android) {

			if (Input.GetKeyUp(KeyCode.Escape)) 
			{

			   //quit application on return button

			   Application.LoadLevel("Menu");
				
			   return;

			}

		}
		
		if (Application.platform == RuntimePlatform.WindowsEditor){
			if (Input.inputString == "\b") {
				Application.LoadLevel("Menu");
				return;
			}
		}
		
	}
	
	public void GoBack()
	{
		Application.LoadLevel("Menu");
	}
	
}

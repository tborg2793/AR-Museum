using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScanHereLanguage : MonoBehaviour {

[SerializeField]
public Text scanText=null;

	// Use this for initialization
	void Start () 
	{
		if(PlayerPrefs.GetString("language")=="UnitedKingdom")
		{
			scanText.text = "Scan Exhibit Here";
		}
		
		if(PlayerPrefs.GetString("language")=="Italy")
		{
			scanText.text = "Scansione la Mostra Qui";
		}
		
		if(PlayerPrefs.GetString("language")=="France")
		{
			scanText.text = "Analyser Exposition Ici";
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

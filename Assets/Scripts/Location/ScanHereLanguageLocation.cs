using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScanHereLanguageLocation : MonoBehaviour {

[SerializeField]
public Text scanText=null;
[SerializeField]
public Text backButtonText=null;

	// Use this for initialization
	void Start () 
	{
		if(PlayerPrefs.GetString("language")=="UnitedKingdom")
		{
			scanText.text = "Scan Exhibit Here To Find Your Location";
			backButtonText.text = "Back";
		}
		
		if(PlayerPrefs.GetString("language")=="Italy")
		{
			scanText.text = "Scansione La Mostra Qui Per Trovare La Tuo Posizione";
			backButtonText.text = "Indietro";
		}
		
		if(PlayerPrefs.GetString("language")=="France")
		{
			scanText.text = "Analyser Exposition Ici Pour Trouver Votre Position";
			backButtonText.text = "Arrière";
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

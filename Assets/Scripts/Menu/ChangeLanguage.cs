using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeLanguage : MonoBehaviour {

[SerializeField]
public Dropdown dp;
[SerializeField]
public Button Play;
[SerializeField]
public Button WhereAmI;
[SerializeField]
public Button TakeQuiz;
[SerializeField]
public Button Exit;
[SerializeField]
public Text LanguageText;
public string language=null;

	// Use this for initialization
	void Start () 
	{
		//language="UnitedKingdom";
		//PlayerPrefs.SetString("language",language);
		
		
		
		if(PlayerPrefs.GetString("language")=="UnitedKingdom")
		{
			language="UnitedKingdom";
			PlayerPrefs.SetString("language",language);
		}
		
		if(PlayerPrefs.GetString("language")=="Italy")
		{
			language="Italy";
			PlayerPrefs.SetString("language",language);
		}
		
		if(PlayerPrefs.GetString("language")=="France")
		{
			language="France";
			PlayerPrefs.SetString("language",language);
		}
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(dp.value == 0)
		{
			Play.GetComponentInChildren<Text>().text = "Play";
			WhereAmI.GetComponentInChildren<Text>().text = "Where Am I?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Take Quiz";
			Exit.GetComponentInChildren<Text>().text = "Exit";
			LanguageText.text = "Language";
			SaveLanguage("UnitedKingdom");
			
		}
		
		if(dp.value == 1)
		{
			Play.GetComponentInChildren<Text>().text = "Gioca";
			WhereAmI.GetComponentInChildren<Text>().text = "Dove sono?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Prendere Quiz";
			Exit.GetComponentInChildren<Text>().text = "Exit";
			LanguageText.text = "Lingua";
			SaveLanguage("Italy");
		}
		
		if(dp.value == 2)
		{
			Play.GetComponentInChildren<Text>().text = "Jouer";
			WhereAmI.GetComponentInChildren<Text>().text = "Où suis-je?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Prenez Quiz";
			Exit.GetComponentInChildren<Text>().text = "Sortie";
			LanguageText.text = "Langue";
			SaveLanguage("France");
		}
	}
	
	void SaveLanguage(string language)
	{
		if(PlayerPrefs.GetString("language")!=language)
		{
			PlayerPrefs.DeleteKey("language");
			PlayerPrefs.SetString("language",language);
			print("New Language Selected - "+PlayerPrefs.GetString("language"));
		}
	}
	
	
	
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class check : MonoBehaviour {
[SerializeField]
public Button Play;
[SerializeField]
public Button WhereAmI;
[SerializeField]
public Button TakeQuiz;
[SerializeField]
public Button Exit;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetString("language") == "UnitedKingdom")
		{
			Play.GetComponentInChildren<Text>().text = "Play";
			WhereAmI.GetComponentInChildren<Text>().text = "Where Am I?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Take Quiz";
			Exit.GetComponentInChildren<Text>().text = "Exit";
			
			
			
		}
		
		if(PlayerPrefs.GetString("language") == "Italy")
		{
			Play.GetComponentInChildren<Text>().text = "Gioca";
			WhereAmI.GetComponentInChildren<Text>().text = "Dove sono?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Prendere Quiz";
			Exit.GetComponentInChildren<Text>().text = "Exit";
			
			
		}
		
		if(PlayerPrefs.GetString("language") == "France")
		{
			Play.GetComponentInChildren<Text>().text = "Jouer";
			WhereAmI.GetComponentInChildren<Text>().text = "Où suis-je?";
			TakeQuiz.GetComponentInChildren<Text>().text = "Prenez Quiz";
			Exit.GetComponentInChildren<Text>().text = "Sortie";
			
		}
	
	}
}

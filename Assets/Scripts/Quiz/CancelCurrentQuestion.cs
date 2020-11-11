using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CancelCurrentQuestion : MonoBehaviour {


	[SerializeField]
    public GameObject QuestionPanel;
	[SerializeField]
    public GameObject ExhibitChoice;
	[SerializeField]
    public Toggle Answer1;
	[SerializeField]
    public Toggle Answer2;
	[SerializeField]
    public Toggle Answer3;
	[SerializeField]
    public Toggle Answer4;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void CancelButton ()
	{
		QuestionPanel.SetActive(false);
		ExhibitChoice.SetActive(true);
		Answer1.isOn = false;
		Answer2.isOn = false;
		Answer3.isOn = false;
		Answer4.isOn = false;
	}
	
}

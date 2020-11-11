using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadQuestions : MonoBehaviour {

	[SerializeField]
    public Texture ExhibitA;
	[SerializeField]
    public Texture ExhibitB;
	[SerializeField]
    public Texture ExhibitC;
	[SerializeField]
    public Texture ExhibitD;
	[SerializeField]
    public Texture ExhibitE;
	[SerializeField]
    public Texture ExhibitF;
	[SerializeField]
    public Texture ExhibitG;
	[SerializeField]
    public Texture ExhibitH;
	[SerializeField]
    public Texture ExhibitI;
	[SerializeField]
    public Texture ExhibitJ;
	
	[SerializeField]
    public RawImage CurrentQuestionImage;
	
	[SerializeField]
    public GameObject QuestionPanel;
	[SerializeField]
    public GameObject ExhibitContainer;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void LoadData (string exhibit) 
	{
		if(exhibit=="ExhibitA")
		{
			CurrentQuestionImage.texture = (Texture)ExhibitA;
			QuestionPanel.SetActive(true);
			ExhibitContainer.SetActive(false);
		}
	}
	
	
}

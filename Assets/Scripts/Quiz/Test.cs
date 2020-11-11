using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Test : MonoBehaviour {

	[SerializeField]
    public Button ExhibitA;
	[SerializeField]
    public Button ExhibitB;
	[SerializeField]
    public Button ExhibitC;
	[SerializeField]
    public Button ExhibitD;
	[SerializeField]
    public Button ExhibitE;
	[SerializeField]
    public Button ExhibitF;
	[SerializeField]
    public Button ExhibitG;
	[SerializeField]
    public Button ExhibitH;
	[SerializeField]
    public Button ExhibitI;
	[SerializeField]
    public Button ExhibitJ;
	
	[SerializeField]
    public Texture ExhibitATexture;
	[SerializeField]
    public Texture ExhibitBTexture;
	[SerializeField]
    public Texture ExhibitCTexture;
	[SerializeField]
    public Texture ExhibitDTexture;
	[SerializeField]
    public Texture ExhibitETexture;
	[SerializeField]
    public Texture ExhibitFTexture;
	[SerializeField]
    public Texture ExhibitGTexture;
	[SerializeField]
    public Texture ExhibitHTexture;
	[SerializeField]
    public Texture ExhibitITexture;
	[SerializeField]
    public Texture ExhibitJTexture;
	
	[SerializeField]
    public RawImage CurrentQuestionImage;
	
	[SerializeField]
    public Text ExhibitTitle=null;
	
	
	[SerializeField]
    public GameObject QuestionPanel;
	
	[SerializeField]
    public GameObject ExhibitContainer;
	
	[SerializeField]
    public Text QuestionText;
	[SerializeField]
    public Text Answer1Text;
	[SerializeField]
    public Text Answer2Text;
	[SerializeField]
    public Text Answer3Text;
	[SerializeField]
    public Text Answer4Text;
	

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		ExhibitA.onClick.AddListener(delegate { LoadData("ExhibitA"); });
		ExhibitB.onClick.AddListener(delegate { LoadData("ExhibitB"); });
		ExhibitC.onClick.AddListener(delegate { LoadData("ExhibitC"); });
		ExhibitD.onClick.AddListener(delegate { LoadData("ExhibitD"); });
		ExhibitE.onClick.AddListener(delegate { LoadData("ExhibitE"); });
		ExhibitF.onClick.AddListener(delegate { LoadData("ExhibitF"); });
		ExhibitG.onClick.AddListener(delegate { LoadData("ExhibitG"); });
		ExhibitH.onClick.AddListener(delegate { LoadData("ExhibitH"); });
		ExhibitI.onClick.AddListener(delegate { LoadData("ExhibitI"); });
		ExhibitJ.onClick.AddListener(delegate { LoadData("ExhibitJ"); });
	}
	
	public void LoadData (string exhibit) 
	{
		
		if(exhibit=="ExhibitA")
		{
			if(PlayerPrefs.GetString("ExhibitA")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitATexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitA";
				QuestionText.text="The River Tiber is the :";
				Answer1Text.text="First Longest River in Italy";
				Answer2Text.text="Second Longest River in Italy";
				Answer3Text.text="Third Longest River in Italy";
				Answer4Text.text="Smallest River in Italy";
			}
		}
		
		if(exhibit=="ExhibitB")
		{
			if(PlayerPrefs.GetString("ExhibitB")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitBTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitB";
				QuestionText.text="Judith’s city lay besieged by the:";
				Answer1Text.text="Ottoman Army";
				Answer2Text.text="Assyrian Army";
				Answer3Text.text="Knights of St John";
				Answer4Text.text="Manchukuo Imperial Army";
			}
		}
		
		if(exhibit=="ExhibitC")
		{
			if(PlayerPrefs.GetString("ExhibitC")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitCTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitC";
				QuestionText.text="The man in this portrait is believed to be:";
				Answer1Text.text="Nicolo Isouard";
				Answer2Text.text="Ludwig van Beethoven";
				Answer3Text.text="Wolfgang Amadeus Mozart";
				Answer4Text.text="Justin Bieber";
			}
		}
		
		if(exhibit=="ExhibitD")
		{
			if(PlayerPrefs.GetString("ExhibitD")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitDTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitD";
				QuestionText.text="This portrait was placed above the tomb of Innocent XII in the crypt of :";
				Answer1Text.text="Santa Maria del Popolo";
				Answer2Text.text="St Clement Basilica";
				Answer3Text.text="Santa Maria Maddalena";
				Answer4Text.text="St Peter’s Church";
			}
		}
		
		if(exhibit=="ExhibitE")
		{
			if(PlayerPrefs.GetString("ExhibitE")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitETexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitE";
				QuestionText.text="Alexander VII was the former:";
				Answer1Text.text="Inquisitor of Malta";
				Answer2Text.text="Grandmaster of the Knights of St John";
				Answer3Text.text="Duke of Malta";
				Answer4Text.text="Bishop of the Church of Malta";
			}
		}
		
		if(exhibit=="ExhibitF")
		{
			if(PlayerPrefs.GetString("ExhibitF")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitFTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitF";
				QuestionText.text="The chalice is decorated with the Coat of arms of a:";
				Answer1Text.text="Maltese Knight";
				Answer2Text.text="Italian Knight";
				Answer3Text.text="French Knight";
				Answer4Text.text="English Knight";
			}
		}
		
		if(exhibit=="ExhibitG")
		{
			if(PlayerPrefs.GetString("ExhibitG")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitGTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitG";
				QuestionText.text="Oxen are usually used in pairs to:";
				Answer1Text.text="Plow";
				Answer2Text.text="Transport Carts";
				Answer3Text.text="Threshing Grain";
				Answer4Text.text="All of the above";
			}
		}
		
		if(exhibit=="ExhibitH")
		{
			if(PlayerPrefs.GetString("ExhibitH")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitHTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitH";
				QuestionText.text="The Virgin Mary holds her hand on her chest in a gesture of:";
				Answer1Text.text="Goodwill";
				Answer2Text.text="Humility";
				Answer3Text.text="Faith";
				Answer4Text.text="Appreciation";
			}
		}
		
		if(exhibit=="ExhibitI")
		{
			if(PlayerPrefs.GetString("ExhibitI")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitITexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitI";
				QuestionText.text="In this portrait, Dante was sleeping on the steps of the:";
				Answer1Text.text="1st terrace";
				Answer2Text.text="2nd terrace";
				Answer3Text.text="7th terrace";
				Answer4Text.text="5th terrace";
			}
		}
		
		if(exhibit=="ExhibitJ")
		{
			if(PlayerPrefs.GetString("ExhibitJ")=="Visited")
			{
				CurrentQuestionImage.texture = (Texture)ExhibitJTexture;
				QuestionPanel.SetActive(true);
				ExhibitContainer.SetActive(false);
				ExhibitTitle.text="ExhibitJ";
				QuestionText.text="This painting entered the collection of the Grand Masters in:";
				Answer1Text.text="Not known";
				Answer2Text.text="18th Century";
				Answer3Text.text="19th Century";
				Answer4Text.text="13th Century";
			}
		}
		
	}
	
	
	
}

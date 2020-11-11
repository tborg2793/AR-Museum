using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuizEnabler : MonoBehaviour {

	[SerializeField]
    public Texture ExhibitCorrect;
	[SerializeField]
    public Texture ExhibitIncorrect;


	[SerializeField]
    public Texture ExhibitAEnabled;
	[SerializeField]
    public Texture ExhibitADisabled;
	[SerializeField]
    public RawImage ExhibitA;
	[SerializeField]
    public GameObject SignExhibitA;
	[SerializeField]
    public RawImage ExhibitAIconCorrect;
	[SerializeField]
    public GameObject ExhibitAIconContainer;
	
	
	[SerializeField]
    public Texture ExhibitBEnabled;
	[SerializeField]
    public Texture ExhibitBDisabled;
	[SerializeField]
    public RawImage ExhibitB;
	[SerializeField]
    public GameObject SignExhibitB;
	[SerializeField]
    public RawImage ExhibitBIconCorrect;
	[SerializeField]
    public GameObject ExhibitBIconContainer;
	
	[SerializeField]
    public Texture ExhibitCEnabled;
	[SerializeField]
    public Texture ExhibitCDisabled;
	[SerializeField]
    public RawImage ExhibitC;
	[SerializeField]
    public GameObject SignExhibitC;
	[SerializeField]
    public RawImage ExhibitCIconCorrect;
	[SerializeField]
    public GameObject ExhibitCIconContainer;
	
	[SerializeField]
    public Texture ExhibitDEnabled;
	[SerializeField]
    public Texture ExhibitDDisabled;
	[SerializeField]
    public RawImage ExhibitD;
	[SerializeField]
    public GameObject SignExhibitD;
	[SerializeField]
    public RawImage ExhibitDIconCorrect;
	[SerializeField]
    public GameObject ExhibitDIconContainer;
	
	[SerializeField]
    public Texture ExhibitEEnabled;
	[SerializeField]
    public Texture ExhibitEDisabled;
	[SerializeField]
    public RawImage ExhibitE;
	[SerializeField]
    public GameObject SignExhibitE;
	[SerializeField]
    public RawImage ExhibitEIconCorrect;
	[SerializeField]
    public GameObject ExhibitEIconContainer;
	
	[SerializeField]
    public Texture ExhibitFEnabled;
	[SerializeField]
    public Texture ExhibitFDisabled;
	[SerializeField]
    public RawImage ExhibitF;
	[SerializeField]
    public GameObject SignExhibitF;
	[SerializeField]
    public RawImage ExhibitFIconCorrect;
	[SerializeField]
    public GameObject ExhibitFIconContainer;
	
	[SerializeField]
    public Texture ExhibitGEnabled;
	[SerializeField]
    public Texture ExhibitGDisabled;
	[SerializeField]
    public RawImage ExhibitG;
	[SerializeField]
    public GameObject SignExhibitG;
	[SerializeField]
    public RawImage ExhibitGIconCorrect;
	[SerializeField]
    public GameObject ExhibitGIconContainer;
	
	[SerializeField]
    public Texture ExhibitHEnabled;
	[SerializeField]
    public Texture ExhibitHDisabled;
	[SerializeField]
    public RawImage ExhibitH;
	[SerializeField]
    public GameObject SignExhibitH;
	[SerializeField]
    public RawImage ExhibitHIconCorrect;
	[SerializeField]
    public GameObject ExhibitHIconContainer;
	
	[SerializeField]
    public Texture ExhibitIEnabled;
	[SerializeField]
    public Texture ExhibitIDisabled;
	[SerializeField]
    public RawImage ExhibitI;
	[SerializeField]
    public GameObject SignExhibitI;
	[SerializeField]
    public RawImage ExhibitIIconCorrect;
	[SerializeField]
    public GameObject ExhibitIIconContainer;
	
	[SerializeField]
    public Texture ExhibitJEnabled;
	[SerializeField]
    public Texture ExhibitJDisabled;
	[SerializeField]
    public RawImage ExhibitJ;
	[SerializeField]
    public GameObject SignExhibitJ;
	[SerializeField]
    public RawImage ExhibitJIconCorrect;
	[SerializeField]
    public GameObject ExhibitJIconContainer;
	
	
	

	// Use this for initialization
	void Start () {
		
		//Answer1.isOn = true;
		
		
			if(PlayerPrefs.GetString("language")=="UnitedKingdom")
			{
				
				if(PlayerPrefs.GetString("ExhibitA")=="")
				{
					ExhibitA.texture = (Texture)ExhibitADisabled;
					SignExhibitA.SetActive(true);
				}
				else
				{
					ExhibitA.texture = (Texture)ExhibitAEnabled;
					SignExhibitA.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="")
					{
						ExhibitAIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="Correct")
					{
						ExhibitAIconContainer.SetActive(true);
						ExhibitAIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="Incorrect")
					{
						ExhibitAIconContainer.SetActive(true);
						ExhibitAIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
					
					
				}
				
				
				if(PlayerPrefs.GetString("ExhibitB")=="")
				{
					ExhibitB.texture = (Texture)ExhibitBDisabled;
					SignExhibitB.SetActive(true);
				}
				else
				{
					ExhibitB.texture = (Texture)ExhibitBEnabled;
					SignExhibitB.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="")
					{
						ExhibitBIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="Correct")
					{
						ExhibitBIconContainer.SetActive(true);
						ExhibitBIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="Incorrect")
					{
						ExhibitBIconContainer.SetActive(true);
						ExhibitBIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitC")=="")
				{
					ExhibitC.texture = (Texture)ExhibitCDisabled;
					SignExhibitC.SetActive(true);
				}
				else
				{
					ExhibitC.texture = (Texture)ExhibitCEnabled;
					SignExhibitC.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="")
					{
						ExhibitCIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="Correct")
					{
						ExhibitCIconContainer.SetActive(true);
						ExhibitCIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="Incorrect")
					{
						ExhibitCIconContainer.SetActive(true);
						ExhibitCIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitD")=="")
				{
					ExhibitD.texture = (Texture)ExhibitDDisabled;
					SignExhibitD.SetActive(true);
				}
				else
				{
					ExhibitD.texture = (Texture)ExhibitDEnabled;
					SignExhibitD.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="")
					{
						ExhibitDIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="Correct")
					{
						ExhibitDIconContainer.SetActive(true);
						ExhibitDIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="Incorrect")
					{
						ExhibitDIconContainer.SetActive(true);
						ExhibitDIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitE")=="")
				{
					ExhibitE.texture = (Texture)ExhibitEDisabled;
					SignExhibitE.SetActive(true);
				}
				else
				{
					ExhibitE.texture = (Texture)ExhibitEEnabled;
					SignExhibitE.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="")
					{
						ExhibitEIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="Correct")
					{
						ExhibitEIconContainer.SetActive(true);
						ExhibitEIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="Incorrect")
					{
						ExhibitEIconContainer.SetActive(true);
						ExhibitEIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitF")=="")
				{
					ExhibitF.texture = (Texture)ExhibitFDisabled;
					SignExhibitF.SetActive(true);
				}
				else
				{
					ExhibitF.texture = (Texture)ExhibitFEnabled;
					SignExhibitF.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="")
					{
						ExhibitFIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="Correct")
					{
						ExhibitFIconContainer.SetActive(true);
						ExhibitFIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="Incorrect")
					{
						ExhibitFIconContainer.SetActive(true);
						ExhibitFIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitG")=="")
				{
					ExhibitG.texture = (Texture)ExhibitGDisabled;
					SignExhibitG.SetActive(true);
				}
				else
				{
					ExhibitG.texture = (Texture)ExhibitGEnabled;
					SignExhibitG.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="")
					{
						ExhibitGIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="Correct")
					{
						ExhibitGIconContainer.SetActive(true);
						ExhibitGIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="Incorrect")
					{
						ExhibitGIconContainer.SetActive(true);
						ExhibitGIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitH")=="")
				{
					ExhibitH.texture = (Texture)ExhibitHDisabled;
					SignExhibitH.SetActive(true);
				}
				else
				{
					ExhibitH.texture = (Texture)ExhibitHEnabled;
					SignExhibitH.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="")
					{
						ExhibitHIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="Correct")
					{
						ExhibitHIconContainer.SetActive(true);
						ExhibitHIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="Incorrect")
					{
						ExhibitHIconContainer.SetActive(true);
						ExhibitHIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitI")=="")
				{
					ExhibitI.texture = (Texture)ExhibitIDisabled;
					SignExhibitI.SetActive(true);
				}
				else
				{
					ExhibitI.texture = (Texture)ExhibitIEnabled;
					SignExhibitI.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="")
					{
						ExhibitIIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="Correct")
					{
						ExhibitIIconContainer.SetActive(true);
						ExhibitIIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="Incorrect")
					{
						ExhibitIIconContainer.SetActive(true);
						ExhibitIIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitJ")=="")
				{
					ExhibitJ.texture = (Texture)ExhibitJDisabled;
					SignExhibitJ.SetActive(true);
				}
				else
				{
					ExhibitJ.texture = (Texture)ExhibitJEnabled;
					SignExhibitJ.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="")
					{
						ExhibitJIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="Correct")
					{
						ExhibitJIconContainer.SetActive(true);
						ExhibitJIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="Incorrect")
					{
						ExhibitJIconContainer.SetActive(true);
						ExhibitJIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
			}
	

	}
	
	// Update is called once per frame

	
	public void UpdateAll()
	{
			if(PlayerPrefs.GetString("language")=="UnitedKingdom")
			{
				
				if(PlayerPrefs.GetString("ExhibitA")=="")
				{
					ExhibitA.texture = (Texture)ExhibitADisabled;
					SignExhibitA.SetActive(true);
				}
				else
				{
					ExhibitA.texture = (Texture)ExhibitAEnabled;
					SignExhibitA.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="")
					{
						ExhibitAIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="Correct")
					{
						ExhibitAIconContainer.SetActive(true);
						ExhibitAIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitAQuiz")=="Incorrect")
					{
						ExhibitAIconContainer.SetActive(true);
						ExhibitAIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
					
					
				}
				
				
				if(PlayerPrefs.GetString("ExhibitB")=="")
				{
					ExhibitB.texture = (Texture)ExhibitBDisabled;
					SignExhibitB.SetActive(true);
				}
				else
				{
					ExhibitB.texture = (Texture)ExhibitBEnabled;
					SignExhibitB.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="")
					{
						ExhibitBIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="Correct")
					{
						ExhibitBIconContainer.SetActive(true);
						ExhibitBIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitBQuiz")=="Incorrect")
					{
						ExhibitBIconContainer.SetActive(true);
						ExhibitBIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitC")=="")
				{
					ExhibitC.texture = (Texture)ExhibitCDisabled;
					SignExhibitC.SetActive(true);
				}
				else
				{
					ExhibitC.texture = (Texture)ExhibitCEnabled;
					SignExhibitC.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="")
					{
						ExhibitCIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="Correct")
					{
						ExhibitCIconContainer.SetActive(true);
						ExhibitCIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitCQuiz")=="Incorrect")
					{
						ExhibitCIconContainer.SetActive(true);
						ExhibitCIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitD")=="")
				{
					ExhibitD.texture = (Texture)ExhibitDDisabled;
					SignExhibitD.SetActive(true);
				}
				else
				{
					ExhibitD.texture = (Texture)ExhibitDEnabled;
					SignExhibitD.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="")
					{
						ExhibitDIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="Correct")
					{
						ExhibitDIconContainer.SetActive(true);
						ExhibitDIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitDQuiz")=="Incorrect")
					{
						ExhibitDIconContainer.SetActive(true);
						ExhibitDIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitE")=="")
				{
					ExhibitE.texture = (Texture)ExhibitEDisabled;
					SignExhibitE.SetActive(true);
				}
				else
				{
					ExhibitE.texture = (Texture)ExhibitEEnabled;
					SignExhibitE.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="")
					{
						ExhibitEIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="Correct")
					{
						ExhibitEIconContainer.SetActive(true);
						ExhibitEIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitEQuiz")=="Incorrect")
					{
						ExhibitEIconContainer.SetActive(true);
						ExhibitEIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitF")=="")
				{
					ExhibitF.texture = (Texture)ExhibitFDisabled;
					SignExhibitF.SetActive(true);
				}
				else
				{
					ExhibitF.texture = (Texture)ExhibitFEnabled;
					SignExhibitF.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="")
					{
						ExhibitFIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="Correct")
					{
						ExhibitFIconContainer.SetActive(true);
						ExhibitFIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitFQuiz")=="Incorrect")
					{
						ExhibitFIconContainer.SetActive(true);
						ExhibitFIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitG")=="")
				{
					ExhibitG.texture = (Texture)ExhibitGDisabled;
					SignExhibitG.SetActive(true);
				}
				else
				{
					ExhibitG.texture = (Texture)ExhibitGEnabled;
					SignExhibitG.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="")
					{
						ExhibitGIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="Correct")
					{
						ExhibitGIconContainer.SetActive(true);
						ExhibitGIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitGQuiz")=="Incorrect")
					{
						ExhibitGIconContainer.SetActive(true);
						ExhibitGIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitH")=="")
				{
					ExhibitH.texture = (Texture)ExhibitHDisabled;
					SignExhibitH.SetActive(true);
				}
				else
				{
					ExhibitH.texture = (Texture)ExhibitHEnabled;
					SignExhibitH.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="")
					{
						ExhibitHIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="Correct")
					{
						ExhibitHIconContainer.SetActive(true);
						ExhibitHIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitHQuiz")=="Incorrect")
					{
						ExhibitHIconContainer.SetActive(true);
						ExhibitHIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitI")=="")
				{
					ExhibitI.texture = (Texture)ExhibitIDisabled;
					SignExhibitI.SetActive(true);
				}
				else
				{
					ExhibitI.texture = (Texture)ExhibitIEnabled;
					SignExhibitI.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="")
					{
						ExhibitIIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="Correct")
					{
						ExhibitIIconContainer.SetActive(true);
						ExhibitIIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitIQuiz")=="Incorrect")
					{
						ExhibitIIconContainer.SetActive(true);
						ExhibitIIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
				
				if(PlayerPrefs.GetString("ExhibitJ")=="")
				{
					ExhibitJ.texture = (Texture)ExhibitJDisabled;
					SignExhibitJ.SetActive(true);
				}
				else
				{
					ExhibitJ.texture = (Texture)ExhibitJEnabled;
					SignExhibitJ.SetActive(false);
					
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="")
					{
						ExhibitJIconContainer.SetActive(false);
					}
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="Correct")
					{
						ExhibitJIconContainer.SetActive(true);
						ExhibitJIconCorrect.texture = (Texture)ExhibitCorrect;
					}
					
					if(PlayerPrefs.GetString("ExhibitJQuiz")=="Incorrect")
					{
						ExhibitJIconContainer.SetActive(true);
						ExhibitJIconCorrect.texture = (Texture)ExhibitIncorrect;
					}
				}
			}
	}
	
	
	
}


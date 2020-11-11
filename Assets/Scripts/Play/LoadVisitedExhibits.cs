using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class LoadVisitedExhibits : MonoBehaviour {

[SerializeField]
public Text VisitedText;
[SerializeField]
public Text TitleVisitedText;

	// Use this for initialization
	void Start () 
	{
			
			// --------------------------------------- United Kingdom Exhibit A B and C
			
			
			if(PlayerPrefs.GetString("language")=="UnitedKingdom")
			{
				TitleVisitedText.text = "Exhibits Visited";
				
				if(PlayerPrefs.GetString("ExhibitA")=="")
				{
					VisitedText.text = "ExhibitA \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text = "ExhibitA \t\t "+PlayerPrefs.GetString("ExhibitA")+"\n";
				}
				
				
		
				
				if(PlayerPrefs.GetString("ExhibitB")=="")
				{
					VisitedText.text += "ExhibitB \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitB \t\t "+PlayerPrefs.GetString("ExhibitB")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitC")=="")
				{
					VisitedText.text += "ExhibitC \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitC \t\t "+PlayerPrefs.GetString("ExhibitC")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitD")=="")
				{
					VisitedText.text += "ExhibitD \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitD \t\t "+PlayerPrefs.GetString("ExhibitD")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitE")=="")
				{
					VisitedText.text += "ExhibitE \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitE \t\t "+PlayerPrefs.GetString("ExhibitE")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitF")=="")
				{
					VisitedText.text += "ExhibitF \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitF \t\t "+PlayerPrefs.GetString("ExhibitF")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitG")=="")
				{
					VisitedText.text += "ExhibitG \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitG \t\t "+PlayerPrefs.GetString("ExhibitG")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitH")=="")
				{
					VisitedText.text += "ExhibitH \t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitH \t\t "+PlayerPrefs.GetString("ExhibitH")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitI")=="")
				{
					VisitedText.text += "ExhibitI \t\t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitI \t\t\t "+PlayerPrefs.GetString("ExhibitI")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitJ")=="")
				{
					VisitedText.text += "ExhibitJ \t\t\t Not Visited\n";
				}
				else
				{
					VisitedText.text += "ExhibitJ \t\t\t "+PlayerPrefs.GetString("ExhibitJ")+"\n";
				}
			}
			
			
			// --------------------------------------- Italy Exhibit A B and C
			
			if(PlayerPrefs.GetString("language")=="Italy")
			{
				
				TitleVisitedText.text = "Mostre Visitati";
				
				if(PlayerPrefs.GetString("ExhibitA_Italy")=="")
				{
					VisitedText.text = "ExhibitA \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text = "ExhibitA \t\t "+PlayerPrefs.GetString("ExhibitA_Italy")+"\n";
				}
				
				
				if(PlayerPrefs.GetString("ExhibitB_Italy")=="")
				{
					VisitedText.text += "ExhibitB \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitB \t\t "+PlayerPrefs.GetString("ExhibitB_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitC_Italy")=="")
				{
					VisitedText.text += "ExhibitC \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitC \t\t "+PlayerPrefs.GetString("ExhibitC_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitD_Italy")=="")
				{
					VisitedText.text += "ExhibitD \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitD \t\t "+PlayerPrefs.GetString("ExhibitD_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitE_Italy")=="")
				{
					VisitedText.text += "ExhibitE \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitE \t\t "+PlayerPrefs.GetString("ExhibitE_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitF_Italy")=="")
				{
					VisitedText.text += "ExhibitF \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitF \t\t "+PlayerPrefs.GetString("ExhibitF_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitG_Italy")=="")
				{
					VisitedText.text += "ExhibitG \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitG \t\t "+PlayerPrefs.GetString("ExhibitG_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitH_Italy")=="")
				{
					VisitedText.text += "ExhibitH \t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitH \t\t "+PlayerPrefs.GetString("ExhibitH_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitI_Italy")=="")
				{
					VisitedText.text += "ExhibitI \t\t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitI \t\t\t "+PlayerPrefs.GetString("ExhibitI_Italy")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitJ_Italy")=="")
				{
					VisitedText.text += "ExhibitJ \t\t\t Non Visitato\n";
				}
				else
				{
					VisitedText.text += "ExhibitJ \t\t\t "+PlayerPrefs.GetString("ExhibitJ_Italy")+"\n";
				}
				
			}
			
			
			// --------------------------------------- France Exhibit A B and C
			
			if(PlayerPrefs.GetString("language")=="France")
			{
				
				TitleVisitedText.text = "Expositions Visité";
				
				if(PlayerPrefs.GetString("ExhibitA_France")=="")
				{
					VisitedText.text = "ExhibitA \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text = "ExhibitA \t\t "+PlayerPrefs.GetString("ExhibitA_France")+"\n";
				}
				
				
				if(PlayerPrefs.GetString("ExhibitB_France")=="")
				{
					VisitedText.text += "ExhibitB \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitB \t\t "+PlayerPrefs.GetString("ExhibitB_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitC_France")=="")
				{
					VisitedText.text += "ExhibitC \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitC \t\t "+PlayerPrefs.GetString("ExhibitC_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitD_France")=="")
				{
					VisitedText.text += "ExhibitD \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitD \t\t "+PlayerPrefs.GetString("ExhibitD_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitE_France")=="")
				{
					VisitedText.text += "ExhibitE \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitE \t\t "+PlayerPrefs.GetString("ExhibitE_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitF_France")=="")
				{
					VisitedText.text += "ExhibitF \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitF \t\t "+PlayerPrefs.GetString("ExhibitF_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitG_France")=="")
				{
					VisitedText.text += "ExhibitG \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitG \t\t "+PlayerPrefs.GetString("ExhibitG_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitH_France")=="")
				{
					VisitedText.text += "ExhibitH \t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitH \t\t "+PlayerPrefs.GetString("ExhibitH_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitI_France")=="")
				{
					VisitedText.text += "ExhibitI \t\t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitI \t\t\t "+PlayerPrefs.GetString("ExhibitI_France")+"\n";
				}
				
				if(PlayerPrefs.GetString("ExhibitJ_France")=="")
				{
					VisitedText.text += "ExhibitJ \t\t\t Ne pas visité\n";
				}
				else
				{
					VisitedText.text += "ExhibitJ \t\t\t "+PlayerPrefs.GetString("ExhibitJ_France")+"\n";
				}
			}
	}
	

	
	
	
	
	
	public void loadVisited(string visitedExhibits)
	{
		VisitedText.text = null;
		
		
		// --------------------------------- United Kingdom
		
		if(PlayerPrefs.GetString("language")=="UnitedKingdom")
		{
			
			if(PlayerPrefs.GetString("ExhibitA")=="")
			{
				VisitedText.text = "ExhibitA \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text = "ExhibitA"+" \t\t "+PlayerPrefs.GetString("ExhibitA")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitB")=="")
			{
				VisitedText.text += "ExhibitB \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitB"+" \t\t "+PlayerPrefs.GetString("ExhibitB")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitC")=="")
			{
				VisitedText.text += "ExhibitC \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitC"+" \t\t "+PlayerPrefs.GetString("ExhibitC")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitD")=="")
			{
				VisitedText.text += "ExhibitD \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitD"+" \t\t "+PlayerPrefs.GetString("ExhibitD")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitE")=="")
			{
				VisitedText.text += "ExhibitE \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitE"+" \t\t "+PlayerPrefs.GetString("ExhibitE")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitF")=="")
			{
				VisitedText.text += "ExhibitF \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitF"+" \t\t "+PlayerPrefs.GetString("ExhibitF")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitG")=="")
			{
				VisitedText.text += "ExhibitG \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitG"+" \t\t "+PlayerPrefs.GetString("ExhibitG")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitH")=="")
			{
				VisitedText.text += "ExhibitH \t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitH"+" \t\t "+PlayerPrefs.GetString("ExhibitH")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitI")=="")
			{
				VisitedText.text += "ExhibitI \t\t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitI"+" \t\t\t "+PlayerPrefs.GetString("ExhibitI")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitJ")=="")
			{
				VisitedText.text += "ExhibitJ \t\t\t Not Visited\n";
			}
			else
			{
				VisitedText.text += "ExhibitJ"+" \t\t\t "+PlayerPrefs.GetString("ExhibitJ")+"\n";
			}
		}
		
		// --------------------------------------- Italy
		
		if(PlayerPrefs.GetString("language")=="Italy")
		{
			
			if(PlayerPrefs.GetString("ExhibitA_Italy")=="")
			{
				VisitedText.text = "ExhibitA \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text = "ExhibitA"+" \t\t "+PlayerPrefs.GetString("ExhibitA_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitB_Italy")=="")
			{
				VisitedText.text += "ExhibitB \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitB"+" \t\t "+PlayerPrefs.GetString("ExhibitB_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitC_Italy")=="")
			{
				VisitedText.text += "ExhibitC \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitC"+" \t\t "+PlayerPrefs.GetString("ExhibitC_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitD_Italy")=="")
			{
				VisitedText.text += "ExhibitD \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitD"+" \t\t "+PlayerPrefs.GetString("ExhibitD_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitE_Italy")=="")
			{
				VisitedText.text += "ExhibitE \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitE"+" \t\t "+PlayerPrefs.GetString("ExhibitE_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitF_Italy")=="")
			{
				VisitedText.text += "ExhibitF \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitF"+" \t\t "+PlayerPrefs.GetString("ExhibitF_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitG_Italy")=="")
			{
				VisitedText.text += "ExhibitG \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitG"+" \t\t "+PlayerPrefs.GetString("ExhibitG_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitH_Italy")=="")
			{
				VisitedText.text += "ExhibitH \t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitH"+" \t\t "+PlayerPrefs.GetString("ExhibitH_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitI_Italy")=="")
			{
				VisitedText.text += "ExhibitI \t\t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitI"+" \t\t\t "+PlayerPrefs.GetString("ExhibitI_Italy")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitJ_Italy")=="")
			{
				VisitedText.text += "ExhibitJ \t\t\t Non Visitato\n";
			}
			else
			{
				VisitedText.text += "ExhibitJ"+" \t\t\t "+PlayerPrefs.GetString("ExhibitJ_Italy")+"\n";
			}
		}
		
		
		//--------------------------------------------- France
		
		if(PlayerPrefs.GetString("language")=="France")
		{
			
			if(PlayerPrefs.GetString("ExhibitA_France")=="")
			{
				VisitedText.text = "ExhibitA \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text = "ExhibitA"+" \t\t "+PlayerPrefs.GetString("ExhibitA_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitB_France")=="")
			{
				VisitedText.text += "ExhibitB \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitB"+" \t\t "+PlayerPrefs.GetString("ExhibitB_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitC_France")=="")
			{
				VisitedText.text += "ExhibitC \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitC"+" \t\t "+PlayerPrefs.GetString("ExhibitC_France")+"\n";
			}
			
			
			if(PlayerPrefs.GetString("ExhibitD_France")=="")
			{
				VisitedText.text += "ExhibitD \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitD"+" \t\t "+PlayerPrefs.GetString("ExhibitD_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitE_France")=="")
			{
				VisitedText.text += "ExhibitE \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitE"+" \t\t "+PlayerPrefs.GetString("ExhibitE_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitF_France")=="")
			{
				VisitedText.text += "ExhibitF \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitF"+" \t\t "+PlayerPrefs.GetString("ExhibitF_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitG_France")=="")
			{
				VisitedText.text += "ExhibitG \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitG"+" \t\t "+PlayerPrefs.GetString("ExhibitG_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitH_France")=="")
			{
				VisitedText.text += "ExhibitH \t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitH"+" \t\t "+PlayerPrefs.GetString("ExhibitH_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitI_France")=="")
			{
				VisitedText.text += "ExhibitI \t\t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitI"+" \t\t\t "+PlayerPrefs.GetString("ExhibitI_France")+"\n";
			}
			
			if(PlayerPrefs.GetString("ExhibitJ_France")=="")
			{
				VisitedText.text += "ExhibitJ \t\t\t Ne pas visité\n";
			}
			else
			{
				VisitedText.text += "ExhibitJ"+" \t\t\t "+PlayerPrefs.GetString("ExhibitJ_France")+"\n";
			}
		}
		
		
		
		
	}
	
}

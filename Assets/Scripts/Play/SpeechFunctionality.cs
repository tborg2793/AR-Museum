using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class SpeechFunctionality : MonoBehaviour {
	
	[SerializeField]
	private Text ExhibitData = null;
	

	
	// Use this for initialization
	void Start () 
	{
		 if(PlayerPrefs.GetString("language")=="UnitedKingdom")
		 {
				EasyTTSUtil.Initialize(EasyTTSUtil.UnitedStates);
		 }
		 
		 if(PlayerPrefs.GetString("language")=="Italy")
		 {
				EasyTTSUtil.Initialize(EasyTTSUtil.Italy);
		 } 
		 
		 if(PlayerPrefs.GetString("language")=="France")
		 {
				EasyTTSUtil.Initialize(EasyTTSUtil.France);
		 } 
		
	}
	
	
	
	public void startReading(string textToRead)
    {
        if (textToRead.Length > 0)
			{
				EasyTTSUtil.SpeechAdd(textToRead);
				
			}
    }


    public void stopReading()
    {
        EasyTTSUtil.StopSpeech();
    }

	
	
	
}


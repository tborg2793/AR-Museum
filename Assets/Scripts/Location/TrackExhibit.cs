using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;



public class TrackExhibit : MonoBehaviour, ITrackableEventHandler {
	
	private TrackableBehaviour mTrackableBehaviour;
    
	public GameObject Map;
    public GameObject arCam;
	public GameObject objectToAccess;
	public GameObject ScanPanel;
	public GameObject BackButton;
	
    //public Transform arrowPosition;

    // Use this for initialization
    void Start () 
	{
		
			Map.SetActive(false);
			ScanPanel.SetActive(true);
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			BackButton.SetActive(false);
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
			}	
		
		
    }

	
		public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
				newStatus == TrackableBehaviour.Status.TRACKED ||
				newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
			{
				//if (Application.platform == RuntimePlatform.Android) 
				//{
					//Handheld.Vibrate();
				//}
				ScanPanel.SetActive(false);
				arCam.SetActive(false);
				Map.SetActive(true);
				BackButton.SetActive(true);
				LoadAnimation scriptToAccess = objectToAccess.GetComponent<LoadAnimation>();
				scriptToAccess.moveArrowAndCamera(mTrackableBehaviour.TrackableName+"_location");
			}
			else
			{
				arCam.SetActive(true);
				Map.SetActive(false);
						
				
			}
		}
	
	
	

}

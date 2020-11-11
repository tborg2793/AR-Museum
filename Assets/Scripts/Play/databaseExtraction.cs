using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Vuforia;
using Mono.Data.Sqlite;
using System.Data;
using System;


public class databaseExtraction : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;
	
	[SerializeField]
	private Text ExhibitID = null;
	[SerializeField]
	private Text ExhibitData = null;
	[SerializeField]
	private GameObject panel = null;
	[SerializeField]
	private GameObject ScanPanel = null;
	[SerializeField]
	private GameObject Slider = null;
	[SerializeField]
	private GameObject ShareButton = null;
	[SerializeField]
	private Button SpeakButton = null;
	[SerializeField]
	private Button StopSpeakButton = null;
	[SerializeField]
	private Button ShowMoreInfo = null;
	private AudioSource audio;
	[SerializeField]
	private AudioClip cow;
       
	
	private string artist;
	private string year;
	private string name;
	private string description;
	private string url;
	private string similarItemsID;
	private string similarItemsName;
	private ArrayList result = null;
	private ArrayList resultSimilarItems = null;
	private string sqlQuery = null;
	private string sqlQuerySimilarItems = null;
	
	// Use this for initialization
	
		void Start()
		{
			//EasyTTSUtil.Initialize(EasyTTSUtil.Italy);
			ExhibitID.text=null;
			ExhibitData.text=null;
			mTrackableBehaviour = GetComponent<TrackableBehaviour>();
			if (mTrackableBehaviour)
			{
				mTrackableBehaviour.RegisterTrackableEventHandler(this);
				
			}
			
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
	
	
	
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
		
		
			
			PlayerPrefs.SetString(mTrackableBehaviour.TrackableName,"Visited");
			PlayerPrefs.SetString(mTrackableBehaviour.TrackableName+"_Italy","Visitato");
			PlayerPrefs.SetString(mTrackableBehaviour.TrackableName+"_France","Visité");
		
		
		
		
		//PlayerPrefs.SetString(mTrackableBehaviour.TrackableName,"Visited");
		
		
		
		print("Prefs added - "+PlayerPrefs.GetString(mTrackableBehaviour.TrackableName));
		
		
		
		
		
		
		Debug.Log("Setting Panel");
		//Debug.Log("Y is - "+transform.eulerAngles.y);
				panel.SetActive(true);
				ScanPanel.SetActive(false);
				ShareButton.SetActive(true);
				
				
				if(PlayerPrefs.GetString("language")=="UnitedKingdom")
				{
					ShowMoreInfo.GetComponentInChildren<Text>().text = "Click here for more information";
				}
				
				if(PlayerPrefs.GetString("language")=="Italy")
				{
					ShowMoreInfo.GetComponentInChildren<Text>().text = "Clicca qui per più informazioni";
				}
				
				if(PlayerPrefs.GetString("language")=="France")
				{
					ShowMoreInfo.GetComponentInChildren<Text>().text = "Cliquez ici pour plus d'informations";
				}
				
				
				//ShowMoreInfo.GetComponentInChildren<Text>().text = "Click here for more information";
				
				if(mTrackableBehaviour.TrackableName=="ExhibitA")
				{
					Slider.SetActive(true);
				}
				
				if(mTrackableBehaviour.TrackableName=="ExhibitG")
				{
					 audio = GetComponent<AudioSource>();
					 audio.PlayOneShot(cow,1F);
				}
				
				
				
				

				LoadVisitedExhibits LVE = GetComponent<LoadVisitedExhibits>();
				LVE.loadVisited(mTrackableBehaviour.TrackableName);
				
				if (Application.platform == RuntimePlatform.Android) 
				{
					DBAndroid();
				}
				
				
				if (Application.platform == RuntimePlatform.WindowsEditor)
				{
					DBWindows();
				}
				
		
	}
	else
		{
			stopReading();
			ExhibitID.text=null;
			ExhibitData.text=null;
			panel.SetActive(false);
			ScanPanel.SetActive(true);
			Slider.SetActive(false);
			ShareButton.SetActive(false);
			artist = null;
			year = null;
			name = null;
			description = null;
			url = null;
			similarItemsID = null;
			similarItemsName = null;
			ShowMoreInfo.GetComponentInChildren<Text>().text = "";
		}
	}


	public void startReading(string textToRead)
		{
			// Read the specified text if the string is not empty
			if (textToRead.Length > 0)
			{
				EasyTTSUtil.SpeechAdd(textToRead);
				
			}
		}

    // Change text for testing if new text is successfully read
   

	public void stopReading()
		{
			EasyTTSUtil.StopSpeech();
		}
		
	
	
	
	
	public void DBAndroid()
	{
		//Handheld.Vibrate();
		dbAccess db = GetComponent<dbAccess>();

        
						db.OpenDB("museumDatabase.db");

						//ArrayList result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
						
						if(PlayerPrefs.GetString("language")=="Italy")
						{
							result = db.SingleSelectWhere("exhibit_italy", "*", "exhibitID", "=", "'"+mTrackableBehaviour.TrackableName+"'");
						}
						if(PlayerPrefs.GetString("language")=="UnitedKingdom")
						{
							result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'"+mTrackableBehaviour.TrackableName+"'");
						}
						if(PlayerPrefs.GetString("language")=="France")
						{
							result = db.SingleSelectWhere("exhibit_france", "*", "exhibitID", "=", "'"+mTrackableBehaviour.TrackableName+"'");
						}
						
						if (result.Count > 0)
						{
							description = "";
							foreach(string[] s in result)
									{
										for (int x =0; x<s.Length; x++ )
										{
											//description += "\n" + s[x];
										}
										artist = s[1];
										year = s[2];
										name = s[3];
										description = s[4];
										url = s[5];
									}
							
						}

						
						
						db.CloseDB();
					


						
						
						
			   
						Debug.Log("Desc - "+description);
						ExhibitID.text=mTrackableBehaviour.TrackableName;
						//ExhibitData.text = description;
						
						
						if(PlayerPrefs.GetString("language")=="Italy")
						{
							ExhibitData.text = "Nome della Mostra: "+name+"\nArtista: "+artist+"\nAnno: "+year+"\n\n"+description+"\n\nArticoli simili\n\n";
						}
						if(PlayerPrefs.GetString("language")=="UnitedKingdom")
						{
							ExhibitData.text = "Exhibit Name: "+name+"\nExhibit Artist: "+artist+"\nYear: "+year+"\n\n"+description+"\n\nSimilar Items\n\n";
						}
						if(PlayerPrefs.GetString("language")=="France")
						{
							ExhibitData.text = "Nom du Exposition: "+name+"\nArtiste: "+artist+"\nAn: "+year+"\n\n"+description+"\n\nDes Articles Similaires\n\n";
						}
						
						
						
						dbAccess dsSimilar = GetComponent<dbAccess>();
						dsSimilar.OpenDB("museumDatabase.db");

						//resultSimilarItems = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
						resultSimilarItems = dsSimilar.SingleSelectWhere("exhibit", "*", "exhibitArtist", "=", "'"+artist+"' AND exhibitID != '"+mTrackableBehaviour.TrackableName+"'");
						
						if (resultSimilarItems.Count > 0)
						{
							
							foreach(string[] similar in resultSimilarItems)
							{
								similarItemsID = similar[0];
								similarItemsName = similar[3];
								ExhibitData.text +=similarItemsID+" - "+similarItemsName+"\n";
							}
								
						}
						
						
						
						
						
						dsSimilar.CloseDB();
						
						SpeakButton.onClick.AddListener(delegate { startReading(ExhibitData.text); }); // - On Click, read the text within the input field
						StopSpeakButton.onClick.AddListener(delegate { stopReading(); }); // - On Click, Stop read the text within the input field
						ShowMoreInfo.onClick.AddListener(delegate { OpenURL(url); });
	}
	
	
	public void DBWindows()
	{
			Debug.Log("Entered Windows");
					 string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconn;
					 dbconn = (IDbConnection) new SqliteConnection(conn);
					 dbconn.Open(); //Open connection to the database.
					 IDbCommand dbcmd = dbconn.CreateCommand();
					 
					 if(PlayerPrefs.GetString("language")=="Italy")
					 {
						sqlQuery = "SELECT * FROM exhibit_italy WHERE exhibitID = "+"'"+mTrackableBehaviour.TrackableName+"'";
					 }
					 if(PlayerPrefs.GetString("language")=="UnitedKingdom")
					 {
						 sqlQuery = "SELECT * FROM exhibit WHERE exhibitID = "+"'"+mTrackableBehaviour.TrackableName+"'";
					 }
					 if(PlayerPrefs.GetString("language")=="France")
					 {
						 sqlQuery = "SELECT * FROM exhibit_france WHERE exhibitID = "+"'"+mTrackableBehaviour.TrackableName+"'";
					 }
					 dbcmd.CommandText = sqlQuery;
					 IDataReader reader = dbcmd.ExecuteReader();
					while (reader.Read())
					{
						artist = reader.GetString(1);
						year = reader.GetString(2);
						name = reader.GetString(3);
						description = reader.GetString(4);
						url = reader.GetString(5);
					}
					 
					
					ExhibitID.text=mTrackableBehaviour.TrackableName;
					
					if(PlayerPrefs.GetString("language")=="Italy")
						{
							ExhibitData.text = "Nome della Mostra: "+name+"\nArtista: "+artist+"\nAnno: "+year+"\n\n"+description+"\n\nArticoli simili\n\n";
						}
						if(PlayerPrefs.GetString("language")=="UnitedKingdom")
						{
							ExhibitData.text = "Exhibit Name: "+name+"\nExhibit Artist: "+artist+"\nYear: "+year+"\n\n"+description+"\n\nSimilar Items\n\n";
						}
						if(PlayerPrefs.GetString("language")=="France")
						{
							ExhibitData.text = "Nom du Exposition: "+name+"\nArtiste: "+artist+"\nAn: "+year+"\n\n"+description+"\n\nDes Articles Similaires\n\n";
						}
					
					
					reader.Close();
					reader = null;
					dbcmd.Dispose();
					dbcmd = null;
					dbconn.Close();
					dbconn = null;
					sqlQuery = null;
					
					
					 string connSimilarItems = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconnSimilarItems;
					 dbconnSimilarItems = (IDbConnection) new SqliteConnection(connSimilarItems);
					 dbconnSimilarItems.Open(); //Open connection to the database.
					 IDbCommand dbcmdSimilarItems = dbconnSimilarItems.CreateCommand();
					 
					 if(PlayerPrefs.GetString("language")=="Italy")
					 {
						sqlQuerySimilarItems = "SELECT * FROM exhibit_italy WHERE exhibitArtist = "+"'"+artist+"' AND exhibitID !='"+mTrackableBehaviour.TrackableName+"'";
					 }
					 if(PlayerPrefs.GetString("language")=="UnitedKingdom")
					 {
						sqlQuerySimilarItems = "SELECT * FROM exhibit WHERE exhibitArtist = "+"'"+artist+"' AND exhibitID !='"+mTrackableBehaviour.TrackableName+"'";
					 }
					 if(PlayerPrefs.GetString("language")=="France")
					 {
						 sqlQuerySimilarItems = "SELECT * FROM exhibit_france WHERE exhibitArtist = "+"'"+artist+"' AND exhibitID !='"+mTrackableBehaviour.TrackableName+"'";
					 }
					 dbcmdSimilarItems.CommandText = sqlQuerySimilarItems;
					 IDataReader readerSimilarItems = dbcmdSimilarItems.ExecuteReader();
						
						if(!readerSimilarItems.IsDBNull(0))
						{
							while (readerSimilarItems.Read())
							{
								similarItemsID = readerSimilarItems.GetString(0);
								similarItemsName = readerSimilarItems.GetString(3);
								ExhibitData.text += similarItemsID+" - "+similarItemsName+"\n";
							}
						}
						else
						{
							ExhibitData.text += "No Similar Items\n";
						}
						
					readerSimilarItems.Close();
					readerSimilarItems = null;
					dbcmdSimilarItems.Dispose();
					dbcmdSimilarItems = null;
					dbconnSimilarItems.Close();
					dbconnSimilarItems = null;
					sqlQuerySimilarItems = null;
					
					
					
					
					
					ShowMoreInfo.onClick.AddListener(delegate { OpenURL(url); });
	}
	
	public void OpenURL(string url)
	{
		Application.OpenURL(url);
	}
	
	
	
	
	
	
	

}

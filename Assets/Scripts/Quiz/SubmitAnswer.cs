using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Vuforia;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class SubmitAnswer : MonoBehaviour {


	[SerializeField]
    public Button SubmitButton;
	[SerializeField]
    public Text ExhibitName;
	
	
	[SerializeField]
    public Toggle Answer1;
	[SerializeField]
    public Toggle Answer2;
	[SerializeField]
    public Toggle Answer3;
	[SerializeField]
    public Toggle Answer4;
	
	[SerializeField]
    public GameObject QuestionPanel;
	
	[SerializeField]
    public GameObject ExhibitContainer;
	
	[SerializeField]
    public RawImage ResultImage;
	[SerializeField]
    public GameObject ResultImageHolder;
	[SerializeField]
    public Texture CorrectSign;
	[SerializeField]
    public Texture IncorrectSign;
	
	
	
	
	
	private string quizSqlAnswer;
	private ArrayList result = null;
	private string sqlQuery = null;
	
	
	
	
	
	

	// Use this for initialization
	void Start () 
	{
	SubmitButton.onClick.AddListener(delegate { CheckCorrect(ExhibitName.text); });
	ResultImageHolder.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	
	public void CheckCorrect (string exhibit) 
	{
		if(Answer1.isOn == true)
		{
			Debug.Log("Answer 1 was chosen");
			Debug.Log(exhibit);
			//Debug.Log(Answer1.GetComponentInChildren<Text>().text);
		
				if (Application.platform == RuntimePlatform.WindowsEditor)
				{
					Debug.Log("Entered Windows");
					 string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconn;
					 dbconn = (IDbConnection) new SqliteConnection(conn);
					 dbconn.Open(); //Open connection to the database.
					 IDbCommand dbcmd = dbconn.CreateCommand();
					 
					
						sqlQuery = "SELECT * FROM exhibit WHERE exhibitID = "+"'"+exhibit+"'";
					 
					 
						
					 dbcmd.CommandText = sqlQuery;
					 IDataReader reader = dbcmd.ExecuteReader();
					while (reader.Read())
					{
						quizSqlAnswer = reader.GetString(6);
					}
					 
					
					reader.Close();
					reader = null;
					dbcmd.Dispose();
					dbcmd = null;
					dbconn.Close();
					dbconn = null;
					sqlQuery = null;
				}
				
				if (Application.platform == RuntimePlatform.Android) 
				{
					dbAccess db = GetComponent<dbAccess>();

			
							db.OpenDB("museumDatabase.db");

							//ArrayList result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
							
							
							if(PlayerPrefs.GetString("language")=="UnitedKingdom")
							{
								result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'"+exhibit+"'");
							}
							
							
							if (result.Count > 0)
							{
								quizSqlAnswer = "";
								foreach(string[] s in result)
								{
									for (int x =0; x<s.Length; x++ )
									{
										//description += "\n" + s[x];
									}
										quizSqlAnswer = s[6];
								}
								
							}

							
							
							db.CloseDB();
				}
				
				
				Debug.Log("SQL Result is "+quizSqlAnswer);
				if(quizSqlAnswer==Answer1.GetComponentInChildren<Text>().text)
				{
					Debug.Log("Compared with SQL. Answer 1 Correct");
					Debug.Log(exhibit+"Quiz");
					PlayerPrefs.SetString(exhibit+"Quiz","Correct");
					ResultImage.texture = (Texture)CorrectSign;
					ResultImageHolder.SetActive(true);
					
				}
				else
				{
					Debug.Log("Compared with SQL. Answer 1 Incorrect");
					PlayerPrefs.SetString(exhibit+"Quiz","Incorrect");
					ResultImage.texture = (Texture)IncorrectSign;
					ResultImageHolder.SetActive(true);
				}
				
				 StartCoroutine(MyMethod());
				
				
				
				
		}
		
		if(Answer2.isOn == true)
		{
			Debug.Log("Answer 2 was chosen");
			Debug.Log(exhibit);
			
			if (Application.platform == RuntimePlatform.WindowsEditor)
				{
					Debug.Log("Entered Windows");
					 string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconn;
					 dbconn = (IDbConnection) new SqliteConnection(conn);
					 dbconn.Open(); //Open connection to the database.
					 IDbCommand dbcmd = dbconn.CreateCommand();
					 
					
						sqlQuery = "SELECT * FROM exhibit WHERE exhibitID = "+"'"+exhibit+"'";
					 
					 
						
					 dbcmd.CommandText = sqlQuery;
					 IDataReader reader = dbcmd.ExecuteReader();
					while (reader.Read())
					{
						quizSqlAnswer = reader.GetString(6);
					}
					 
					
					reader.Close();
					reader = null;
					dbcmd.Dispose();
					dbcmd = null;
					dbconn.Close();
					dbconn = null;
					sqlQuery = null;
				}
				
				if (Application.platform == RuntimePlatform.Android) 
					{
						dbAccess db = GetComponent<dbAccess>();

				
								db.OpenDB("museumDatabase.db");

								//ArrayList result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
								
								
								if(PlayerPrefs.GetString("language")=="UnitedKingdom")
								{
									result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'"+exhibit+"'");
								}
								
								
								if (result.Count > 0)
								{
									quizSqlAnswer = "";
									foreach(string[] s in result)
									{
										for (int x =0; x<s.Length; x++ )
										{
											//description += "\n" + s[x];
										}
											quizSqlAnswer = s[6];
									}
									
								}

								
								
								db.CloseDB();
					}
				
				
				Debug.Log("SQL Result is "+quizSqlAnswer);
				
				if(quizSqlAnswer==Answer2.GetComponentInChildren<Text>().text)
				{
					Debug.Log("Compared with SQL. Answer 2 Correct");
					PlayerPrefs.SetString(exhibit+"Quiz","Correct");
					ResultImage.texture = (Texture)CorrectSign;
					ResultImageHolder.SetActive(true);
				}
				else
				{
					Debug.Log("Compared with SQL. Answer 2 Incorrect");
					PlayerPrefs.SetString(exhibit+"Quiz","Incorrect");
					ResultImage.texture = (Texture)IncorrectSign;
					ResultImageHolder.SetActive(true);
				}
				
				 StartCoroutine(MyMethod());
				
			
		}
		
		
		
		
		if(Answer3.isOn == true)
		{
			Debug.Log("Answer 3 was chosen");
			Debug.Log(exhibit);
			
			
			if (Application.platform == RuntimePlatform.WindowsEditor)
			{		
				Debug.Log("Entered Windows");
					 string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconn;
					 dbconn = (IDbConnection) new SqliteConnection(conn);
					 dbconn.Open(); //Open connection to the database.
					 IDbCommand dbcmd = dbconn.CreateCommand();
					 
					
						sqlQuery = "SELECT * FROM exhibit WHERE exhibitID = "+"'"+exhibit+"'";
					 
					 
						
					 dbcmd.CommandText = sqlQuery;
					 IDataReader reader = dbcmd.ExecuteReader();
					while (reader.Read())
					{
						quizSqlAnswer = reader.GetString(6);
					}
					 
					
					reader.Close();
					reader = null;
					dbcmd.Dispose();
					dbcmd = null;
					dbconn.Close();
					dbconn = null;
					sqlQuery = null;
			}
			
			if (Application.platform == RuntimePlatform.Android) 
			{
				dbAccess db = GetComponent<dbAccess>();

        
						db.OpenDB("museumDatabase.db");

						//ArrayList result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
						
						
						if(PlayerPrefs.GetString("language")=="UnitedKingdom")
						{
							result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'"+exhibit+"'");
						}
						
						
						if (result.Count > 0)
						{
							quizSqlAnswer = "";
							foreach(string[] s in result)
							{
								for (int x =0; x<s.Length; x++ )
								{
									//description += "\n" + s[x];
								}
									quizSqlAnswer = s[6];
							}
							
						}

						
						
						db.CloseDB();
			}
			
			
			
			
				Debug.Log("SQL Result is "+quizSqlAnswer);
				if(quizSqlAnswer==Answer3.GetComponentInChildren<Text>().text)
				{
					Debug.Log("Compared with SQL. Answer 3 Correct");
					PlayerPrefs.SetString(exhibit+"Quiz","Correct");
					ResultImage.texture = (Texture)CorrectSign;
					ResultImageHolder.SetActive(true);
				}
				else
				{
					Debug.Log("Compared with SQL. Answer 4 Incorrect");
					PlayerPrefs.SetString(exhibit+"Quiz","Incorrect");
					ResultImage.texture = (Texture)IncorrectSign;
					ResultImageHolder.SetActive(true);
				}
				
				StartCoroutine(MyMethod());
		}
		
		
		if(Answer4.isOn == true)
		{
			Debug.Log("Answer 4 was chosen");
			Debug.Log(exhibit);
			
			
			if (Application.platform == RuntimePlatform.WindowsEditor)
			{		
				Debug.Log("Entered Windows");
					 string conn = "URI=file:" + Application.dataPath + "/StreamingAssets/museumDatabase.db"; //Path to database.
					 IDbConnection dbconn;
					 dbconn = (IDbConnection) new SqliteConnection(conn);
					 dbconn.Open(); //Open connection to the database.
					 IDbCommand dbcmd = dbconn.CreateCommand();
					 
					
						sqlQuery = "SELECT * FROM exhibit WHERE exhibitID = "+"'"+exhibit+"'";
					 
					 
						
					 dbcmd.CommandText = sqlQuery;
					 IDataReader reader = dbcmd.ExecuteReader();
					while (reader.Read())
					{
						quizSqlAnswer = reader.GetString(6);
					}
					 
					
					reader.Close();
					reader = null;
					dbcmd.Dispose();
					dbcmd = null;
					dbconn.Close();
					dbconn = null;
					sqlQuery = null;
			}
			
			if (Application.platform == RuntimePlatform.Android) 
			{
				dbAccess db = GetComponent<dbAccess>();

        
						db.OpenDB("museumDatabase.db");

						//ArrayList result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'ExhibitB'");
						
						
						if(PlayerPrefs.GetString("language")=="UnitedKingdom")
						{
							result = db.SingleSelectWhere("exhibit", "*", "exhibitID", "=", "'"+exhibit+"'");
						}
						
						
						if (result.Count > 0)
						{
							quizSqlAnswer = "";
							foreach(string[] s in result)
							{
								for (int x =0; x<s.Length; x++ )
								{
									//description += "\n" + s[x];
								}
									quizSqlAnswer = s[6];
							}
							
						}

						
						
						db.CloseDB();
			}
			
			
			
			
				Debug.Log("SQL Result is "+quizSqlAnswer);
				if(quizSqlAnswer==Answer4.GetComponentInChildren<Text>().text)
				{
					Debug.Log("Compared with SQL. Answer 4 Correct");
					PlayerPrefs.SetString(exhibit+"Quiz","Correct");
					ResultImage.texture = (Texture)CorrectSign;
					ResultImageHolder.SetActive(true);
				}
				else
				{
					Debug.Log("Compared with SQL. Answer 4 Incorrect");
					PlayerPrefs.SetString(exhibit+"Quiz","Incorrect");
					ResultImage.texture = (Texture)IncorrectSign;
					ResultImageHolder.SetActive(true);
				}
				
				StartCoroutine(MyMethod());
		}
	}
	
	
	
	
	
	
	IEnumerator MyMethod() 
	{
		QuizEnabler QE = GetComponent<QuizEnabler>();
		QE.UpdateAll();
		Answer1.isOn = false;
		Answer2.isOn = false;
		Answer3.isOn = false;
		Answer4.isOn = false;
		quizSqlAnswer=null;
		result=null;
		yield return new WaitForSeconds(3);
		Debug.Log("After Waiting 2 seconds");
		QuestionPanel.SetActive(false);
		ExhibitContainer.SetActive(true);
		ResultImageHolder.SetActive(false);
	}
	
	
	
	
	

}

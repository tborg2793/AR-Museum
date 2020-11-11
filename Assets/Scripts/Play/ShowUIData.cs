using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowUIData : MonoBehaviour {

	[SerializeField]
	private GameObject panel = null;
	[SerializeField]
	private GameObject slide = null;

	// Use this for initialization
	void Start () {
	
	panel.SetActive(false);
	slide.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

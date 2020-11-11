using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHideVisitedPanel : MonoBehaviour {

	
	[SerializeField]
    public Texture HideTexture;
	[SerializeField]
    public Texture ShowTexture;
	[SerializeField]
    public RawImage img;
	[SerializeField]
	public Animator anim;
	[SerializeField]
	public bool check;
	[SerializeField]
	private GameObject ScanPanel = null;
	[SerializeField]
	private Text ExhibitInfo = null;
	
	
	void Start () 
	{
		anim.enabled = false;
		check = true;
	}
	
	// Update is called once per frame
	public void Press () 
	{
		if(check==true)
		{
			anim.enabled = true;
			anim.Play("ShowVisitedPanelAnim");
			img.texture = (Texture)HideTexture;
			check = false;
			
			
		}
		
		else if(check==false)
		{
			anim.enabled = true;
			anim.Play("HideVisitedPanelAnim");
			img.texture = (Texture)ShowTexture;
			check = true;
		}
	}
}

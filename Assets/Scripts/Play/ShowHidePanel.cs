using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHidePanel : MonoBehaviour {

	
	[SerializeField]
    public Texture HideTexture;
	[SerializeField]
    public Texture ShowTexture;
	[SerializeField]
    public RawImage img;
	[SerializeField]
	public Animator ani;
	[SerializeField]
	public bool check;

	
	
	void Start () 
	{
		ani.enabled = false;
		check = true;
	}
	
	// Update is called once per frame
	public void Press () 
	{
		if(check==true)
		{
			ani.enabled = true;
			ani.Play("HidePanelAnim");
			img.texture = (Texture)ShowTexture;
			check = false;
		}
		
		else if(check==false)
		{
			ani.enabled = true;
			ani.Play("ShowPanelAnim");
			img.texture = (Texture)HideTexture;
			//img.enabled = false;
			check = true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class rotateExhibitA : MonoBehaviour {
	// Use this for initialization
	
	public float rotationX = 0.0f;
	public float rotationY = 0.0f;
	public float rotationZ = 0.0f;
	
	public float smooth = 1.0F;
	
	void Start () 
	{
		 rotationX = transform.eulerAngles.x;
		 rotationY = transform.eulerAngles.y;
		 rotationZ = transform.eulerAngles.z;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Quaternion target = Quaternion.Euler(rotationX, rotationY, rotationZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, smooth);
	}
	
	public void AdjustRotation(float newRotation)
	{
		rotationX =newRotation-180;
	}
	
}

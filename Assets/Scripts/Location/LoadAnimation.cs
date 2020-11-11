using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class LoadAnimation : MonoBehaviour {
    private string location;
    public GameObject exhibitA;
    public GameObject exhibitB;
    public GameObject exhibitC;
    public GameObject exhibitD;
    public GameObject exhibitE;
    public GameObject exhibitF;
    public GameObject exhibitG;
    public GameObject exhibitH;
    public GameObject exhibitI;
    public GameObject exhibitJ;
    public Camera c;
	public float smooth = 1.0F;
	public float rotationX = 54.8489f;
	public float rotationY = 232.0776f;
	public float rotationZ = 357.2896f;
	
	
    //public Transform arrowPosition;

    // Use this for initialization
    void Start () 
	{
    }

    public void moveArrowAndCamera(string location)
    {
		Vector3 temp = new Vector3(563.6322f,415.6596f,361.0307f);
		c.transform.position = temp;
		
		c.transform.rotation = Quaternion.Euler(54.8489f, 232.0776f, 357.2896f);
		
		GameObject locationObject = GameObject.Find(location);
      
        StartCoroutine(Transition(locationObject.transform));
    }

   
	
    public float transitionDuration = 5.0f;
    //move camera to position
    IEnumerator Transition(Transform location)
    {
        float t = 0.0f;
        Vector3 startingPos = c.transform.position;
        Quaternion startingRot = c.transform.rotation;

        Vector3 endPos = location.position;
        Quaternion endRot = location.rotation;
        
        while (t < 1.0f)
        {
            t += Time.deltaTime * (Time.timeScale / transitionDuration);

            c.transform.position = Vector3.Lerp(startingPos, endPos, t);
            c.transform.rotation = Quaternion.Slerp(startingRot, endRot, t);
            yield return 0;
        }

    }

    void update()
    {
        moveCameraControls();
    }

    public Vector3 pos;
    float speed = 10.0f;
    private void moveCameraControls()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }

            else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                           0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }
        }

        if (Application.platform == RuntimePlatform.Android){
                
        }     

    }

   
}

using UnityEngine;
using System.Collections;

public class ControlCam2 : MonoBehaviour {

	// Use this for initialization
	public float moveSpeed=.5f;
	public float rotSpeed=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float mouseX=Input.GetAxis("Mouse X")*rotSpeed;
		float mouseY=Input.GetAxis("Mouse Y")*moveSpeed;
		
		transform.Rotate(0f,0f,mouseX);
		transform.Translate(0f,0f,mouseY);
	}
}

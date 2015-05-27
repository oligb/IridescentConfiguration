using UnityEngine;
using System.Collections;

public class moveGuy : MonoBehaviour {

	// Use this for initialization
	public float speed=5f;
	public float mouseSpeed=5f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward*speed);

		float mouseX=Input.GetAxis("Mouse X")*mouseSpeed;
		float mouseY=Input.GetAxis("Mouse Y")*mouseSpeed;
		
		transform.Rotate(-mouseY,mouseX,0f);
	}
}

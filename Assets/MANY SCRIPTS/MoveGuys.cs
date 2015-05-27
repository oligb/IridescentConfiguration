using UnityEngine;
using System.Collections;

public class MoveGuys : MonoBehaviour {
	
	// Use this for initialization
	
	// Use this for initialization
	public float inputScale=5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal")*inputScale;
		float inputY= Input.GetAxis("Vertical")*inputScale;
		transform.Translate(inputX,inputY,0f);
		transform.Rotate(inputX*10f,inputY*10f,0f);
		//transform.localScale=new Vector3(inputX,inputY,inputX);
		//transform.Rotate(mouseX,mouseY,mouseX+mouseY);
		
	}
}
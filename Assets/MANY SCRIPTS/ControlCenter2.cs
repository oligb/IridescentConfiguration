using UnityEngine;
using System.Collections;

public class ControlCenter3 : MonoBehaviour {
	
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
		//transform.Rotate(mouseX,mouseY,mouseX+mouseY);
		
	}
}
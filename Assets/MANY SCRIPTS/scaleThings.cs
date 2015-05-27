using UnityEngine;
using System.Collections;

public class scaleThings : MonoBehaviour {

	// Use this for initialization
	public float inputScale=5f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mouseX=Input.GetAxis("Horizontal")*inputScale;
		float mouseY=Input.GetAxis("Vertical")*inputScale;
		Vector3 newScale= new Vector3(mouseX+mouseY,mouseX+mouseY,1.8f) + Vector3.one;
		transform.localScale= newScale;
	}
}

﻿using UnityEngine;
using System.Collections;

public class controlCenter : MonoBehaviour {

	// Use this for initialization
	public float mouseScale=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputY= Input.GetAxis("Vertical");
		transform.Translate(0f,inputY,-inputX);
		float mouseX= mouseScale * Input.GetAxis ("Mouse X");
		float mouseY= mouseScale * Input.GetAxis ("Mouse Y");
		transform.Rotate(mouseX,mouseY,mouseX+mouseY);

	}
}

using UnityEngine;
using System.Collections;

public class MoveMaster : MonoBehaviour {

	// Use this for initialization
	public float moveScale=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal")*moveScale;
		float inputY= Input.GetAxis("Vertical")*moveScale;
		transform.Rotate(inputX,inputY,0f);
	}
}

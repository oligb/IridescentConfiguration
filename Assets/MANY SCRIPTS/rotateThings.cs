using UnityEngine;
using System.Collections;

public class rotateThings : MonoBehaviour {

	// Use this for initialization
	public float rotSpeed=5f;
	void Start () {
		rotSpeed=Random.Range(-3f,3f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,rotSpeed);
	}
}

using UnityEngine;
using System.Collections;

public class FlashColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey("space")){
			GetComponentInChildren<MeshRenderer>().enabled=true;
		}
		else{
			GetComponentInChildren<MeshRenderer>().enabled=false;
		}
	}
}

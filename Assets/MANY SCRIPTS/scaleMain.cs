using UnityEngine;
using System.Collections;

public class scaleMain : MonoBehaviour {

	// Use this for initialization
	public float addedScale;
	public float scaleSpeed=.1f;
	public float maxScale=5f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("space")){
			if(addedScale<=maxScale){
			addedScale+=scaleSpeed;
			}
		}
		else{
			if(addedScale>=1f){
			addedScale-=scaleSpeed;
			}
		}
	
		transform.localScale=addedScale*Vector3.one+Vector3.one;
	}
}

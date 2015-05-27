using UnityEngine;
using System.Collections;

public class ColorPerlins : MonoBehaviour {

	// Use this for initialization
	public float colTemp=0f;
	public float inputScale=10f;
	public float sat;
	void Start () {
		sat=Random.Range(.3f,1f);
		//inputScale=Random.Range(100f,200f);
	}
	
	// Update is called once per frame
	void Update () {

		float mouseX=Input.GetAxis("Mouse X")/inputScale;
		float mouseY=Input.GetAxis("Mouse Y");
		colTemp+=Mathf.Abs(mouseX);
		if(colTemp>=1f){
			colTemp=0f;
		}
		Color col1= HSVRGB.HSVToRGB(colTemp,sat,.6f);
		GetComponent<MeshRenderer>().materials[0].color=col1;
	}
}

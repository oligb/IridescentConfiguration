using UnityEngine;
using System.Collections;

public class ChangeSphereColors : MonoBehaviour {
	//public float ThisIsAVeryLongVariableNameASDFDKALKDQOWKEOAPCKASPCLASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPAPDLWOKQOEJQOEQWEPQDPALSEPLQEP=2f;
	// Use this for initialization
	//public Color col;

	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;
	public GameObject manager;

	void Start () {
		manager=GameObject.Find("manager");
		Colors();
		GetComponent<MeshRenderer>().materials[0].color=Color.black;
		
	}
	
	// Update is called once per frame
	void Update () {


		sphereHue=manager.GetComponent<ColorManager3>().sphereHue;
		traileHue=manager.GetComponent<ColorManager3>().traileHue;
		if(Input.GetKeyDown("space")){

			Colors();
		}
		
	}
	
	void Colors(){
		/*
		Color col= HSVRGB.HSVToRGB(sphereHue,1f,Random.Range(.8f,1f));
		GetComponent<MeshRenderer>().materials[0].color=col;
		*/

		Color col2= HSVRGB.HSVToRGB(traileHue,Random.Range(.5f,1f),Random.Range(.8f,1f));
		GetComponent<TrailRenderer>().materials[0].color=col2;

		float cubeHue=traileHue+.5f;
		if(cubeHue>=1f){
			cubeHue-=1f;
		}

		Color col3= HSVRGB.HSVToRGB(cubeHue,.8f,1f);
		Color col4= HSVRGB.HSVToRGB(cubeHue,Random.Range(.5f,1f),1f);
		//GetComponent<MeshRenderer>().materials[0].color=col4;
		Camera.main.GetComponentInChildren<MeshRenderer>().materials[0].color=col3;
	}
}

using UnityEngine;
using System.Collections;

public class NewSphereColors : MonoBehaviour {
	//public float ThisIsAVeryLongVariableNameASDFDKALKDQOWKEOAPCKASPCLASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPASDFDKALKDQOWKEOAPCKASPCLAPDLWOKQOEJQOEQWEPQDPALSEPLQEPAPDLWOKQOEJQOEQWEPQDPALSEPLQEP=2f;
	// Use this for initialization
	//public Color col;
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;
	public GameObject manager;
	
	void Start () {
		manager=GameObject.Find("manager");
		Invoke ("Colors",.1f);
		//GetComponent<MeshRenderer>().materials[0].color=Color.black;
		
	}
	
	// Update is called once per frame
	void Update () {
		sphereHue=manager.GetComponent<ColorManager>().sphereHue;
		traileHue=manager.GetComponent<ColorManager>().traileHue;
		traileHue2=manager.GetComponent<ColorManager>().traileHue;




	}
	
	public void Colors(){


		Color col= HSVRGB.HSVToRGB(sphereHue,Random.Range(.3f,.8f),1f);
		GetComponent<MeshRenderer>().materials[0].color=col;
		
		
		//Color col= GetComponent<TrailRenderer>().materials[0].color;
		//col.g=Random.Range(0f,.8f);
		
		Color col2= HSVRGB.HSVToRGB(traileHue,Random.Range(.3f,.8f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color1",col2);
		
		Color col3= HSVRGB.HSVToRGB(traileHue2,Random.Range(.3f,.8f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color2",col3);
		Color col4= HSVRGB.HSVToRGB(traileHue2,Random.Range(.3f,.8f),Random.Range (.8f,1f));
		Camera.main.backgroundColor=col4;
		/*


		Color col= HSVRGB.HSVToRGB(sphereHue,Random.Range(.5f,1f),1f);
		GetComponent<MeshRenderer>().materials[0].color=col;

		Color col2= HSVRGB.HSVToRGB(traileHue,Random.Range(.5f,1f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color1",col2);

		Color col3= HSVRGB.HSVToRGB(traileHue2,Random.Range(.8f,1f),1f);
		GetComponent<TrailRenderer>().materials[0].SetColor("_color2",col3);

		Camera.main.backgroundColor=col3;
/*
		
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
		*/
	}
}

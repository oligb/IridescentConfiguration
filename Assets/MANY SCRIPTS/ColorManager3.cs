using UnityEngine;
using System.Collections;

public class ColorManager3 : MonoBehaviour {
	
	// Use this for initialization
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown("space")){

			/*
			sphereHue+=Random.Range(.2f,.5f);
			if(sphereHue>=1f){
				sphereHue-=1f;
			}

			float tHue=sphereHue+.5f;
			if(tHue>=1f){
				traileHue=tHue-1f;
			}
			else{
				traileHue=tHue;
		}
*/

			traileHue=Random.Range(0f,1f);
}
		
	}
}

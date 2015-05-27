using UnityEngine;
using System.Collections;

public class ColorManager : MonoBehaviour {

	// Use this for initialization
	
	public float sphereHue=.2f;
	public float traileHue=.2f;
	public float traileHue2=.2f;
	public float incColor=.1f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetKeyDown("space")){
			sphereHue=Random.Range(0f,1f);
			traileHue=Random.Range(0f,1f);
			traileHue2=Random.Range(0f,1f);
		}



		 */
		if(Input.GetKeyDown("space")){
			ChangeColors();
		}
	}

	public void ChangeColors(){

		sphereHue=Random.Range(0f,1f);
		traileHue=Random.Range(0f,1f);
		traileHue2=Random.Range(0f,1f);


		/*
		sphereHue+=incColor;
		if(sphereHue>=1f){
			sphereHue-=1f;
		}

		traileHue+=incColor;
		if(traileHue>=1f){
			traileHue-=1f;
		}

		traileHue2+=incColor;
		if(traileHue2>=1f){
			traileHue2-=1f;
		}
*/

	}
}

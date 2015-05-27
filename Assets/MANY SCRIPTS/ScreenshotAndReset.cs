using UnityEngine;
using System.Collections;

public class ScreenshotAndReset : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("Screenshot",60f,10f);
	}
	void Screenshot(){
		
		Application.CaptureScreenshot( Time.time.ToString() + Time.unscaledTime.ToString() + ".png" );
	}
	// Update is called once per frame
	void Update () {

		Cursor.visible=false;

		if(Input.GetKeyDown(KeyCode.Alpha0)){
			Application.LoadLevel(Application.loadedLevel);
		}		
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			Application.LoadLevel("spinnyColors");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			Application.LoadLevel("kinectCubes");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			Application.LoadLevel("Spheres");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha4)){
			Application.LoadLevel("cubesFlowingAround");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha5)){
			Application.LoadLevel("ProperCubeScene");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha6)){
			Application.LoadLevel("cubesMovinAroundEh");
		}
		
		if(Input.GetKeyDown(KeyCode.Alpha7)){
			Application.LoadLevel("perlinCubes");
		}		
		if(Input.GetKeyDown(KeyCode.Alpha8)){
			Application.LoadLevel("shooterVersion");
		}
		if(Input.GetKeyDown(KeyCode.Alpha9)){
			Application.LoadLevel("birds2");
		}


		
		
		
	}
}

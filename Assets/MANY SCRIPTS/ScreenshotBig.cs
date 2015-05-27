using UnityEngine;
using System.Collections;

public class ScreenshotBig : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.P)){
			Application.CaptureScreenshot( Time.time.ToString() + Time.unscaledTime.ToString() + ".png",6 );
		}
	}
}

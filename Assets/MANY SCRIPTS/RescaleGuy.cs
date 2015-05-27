using UnityEngine;
using System.Collections;

public class RescaleGuy : MonoBehaviour {

	// Use this for initialization
	public float scaleSpeed=.1f;
	public TrailRenderer trail;

	public float perlinPos;
	public float perlinInc=.1f;
	public float perlinScale=.5f;
	public float pulseScale=0f;
	public float pulseSpeed=.01f;
	public AnimationCurve curve;
	public float curveScale=2f;

	void Start () {

		perlinPos=Random.Range(0f,1000f);
		trail=GetComponent<TrailRenderer>();
	
	}

	IEnumerator Pulse(){
		float i=0f;
		pulseScale=0f;
		bool changed=false;
		while(i<=1.5f){
			pulseScale=curve.Evaluate(i)*curveScale;
			i+=pulseSpeed;

			if(i>=.7f&&!changed){
				changed=true;
				//GetComponent<NewSphereColors>().manager.GetComponent<ColorManager>().ChangeColors();
				GetComponent<NewSphereColors>().Colors();
			}
			yield return null;
		}


		yield break;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			StartCoroutine("Pulse");

		}

		float scale =  (.5f -Mathf.PerlinNoise(perlinPos,0f))*perlinScale;


		Vector3 scaleVector= (scale+pulseScale) * Vector3.one;

		//Vector3 scale=transform.localScale= (.5f -Mathf.PerlinNoise(perlinPos,0f))*Vector3.one*perlinScale;

		transform.localScale=scaleVector;
		trail.startWidth=(scale+pulseScale)*2f;
		trail.time=scale;


		  perlinPos+=perlinInc;



		/*

		if(Input.GetKey(KeyCode.O)){
			Vector3 scale=transform.localScale +=Vector3.one*scaleSpeed;
			transform.localScale=scale;
			trail.startWidth+=scaleSpeed;
		}
		else if(Input.GetKey(KeyCode.L)){
			Vector3 scale=transform.localScale -=Vector3.one*scaleSpeed;
			transform.localScale=scale;
			trail.startWidth-=scaleSpeed;
		}
*/
	
	}
}

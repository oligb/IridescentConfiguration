using UnityEngine;
using System.Collections;

public class moveText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("MoveText");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator MoveText(){
		float i=0f;
		while(i<1f){
			float yVal=Mathf.Lerp(-100f,11f,i);
			GetComponent<RectTransform>().anchoredPosition=new Vector3(0f,yVal,0f);
			i+=.01f;
			yield return 0;
		}
		yield return new WaitForSeconds(6f);
		float j=0f;
		while(j<1f){
			float yVal=Mathf.Lerp(11f,-100f,j);
			GetComponent<RectTransform>().anchoredPosition=new Vector3(0f,yVal,0f);
			j+=.02f;
			yield return 0;
		}
		yield break;

	}
}

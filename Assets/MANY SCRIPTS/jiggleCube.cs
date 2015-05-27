﻿using UnityEngine;
using System.Collections;

public class jiggleCube : MonoBehaviour {

	// Use this for initialization
	public float scaler=5f;
	public float scaleScaler=.5f;
	public float perlinScaler=5f;
	public float color=0f;
	public float perlinLoc=1000f;
	public float perlinScrollSpeed=1f;
	public float moveSpeed=100f;
	void Start () {
		//StartCoroutine(ScalerManager());
		//StartCoroutine(PerlinManager());
	}
	IEnumerator ScalerManager(){
	while(scaler<10f){
			scaler*=1.001f;
			yield return 0;
		}
	}


	// ENUMERATE THE LERP INCREMENTOR


	IEnumerator PerlinManager(){
		while(perlinScaler<10f){
			perlinScaler*=1.001f;
			yield return 0;
		}
	}


	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetKey(KeyCode.W)){
			scaler+=scaleSpeed;
		}
		else if(Input.GetKey(KeyCode.W)){
			scaler-=scaleSpeed; 
		}

		*/

		float mouseX=Input.GetAxis("Horizontal");
		float mouseY=Input.GetAxis("Vertical");

		scaler=2f+mouseX;

		perlinLoc+=mouseY/moveSpeed;
		/*
		scaler+=scaleScaler;
		perlinScaler+=scaleScaler;


		while(scaler<10){
			scaler*=1.1;
			yield return;
		}
*/
	}
}

using UnityEngine;
using System.Collections;

public class lookatPlayer : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	void Start () {
		player=GameObject.Find("PlayerObject");
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt(player.transform.position);
	}
}

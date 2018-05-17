using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EndingScript : MonoBehaviour {

	public GameObject player;
	public GameObject endtxt;
	public GameObject canv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="player"){

			player.GetComponent<PlayerController> ().enabled = false;
			player.GetComponent<FirstPersonController> ().enabled = false;
			endtxt.gameObject.SetActive (true);
			canv.gameObject.SetActive (false);

			
		

		}
	}
}

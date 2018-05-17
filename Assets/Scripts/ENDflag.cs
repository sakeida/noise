using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ENDflag : MonoBehaviour {
	public GameObject came;
	public GameObject controller;
	public GameObject txt;
	 GlitchFx player;

	// Use this for initialization
	void Start () {
		
	}
		

	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "player") {
			
		
			PlayerController.FLAG++;
			player=came.GetComponent<GlitchFx> ();
			player.intensity = 0.5f;
			txt.gameObject.SetActive (true);
			StartCoroutine ("NOISE");
			controller.GetComponent<FirstPersonController>().enabled = false;
			controller.GetComponent<PlayerController> ().enabled = false;

		}
	}
	IEnumerator NOISE(){
		yield return new WaitForSeconds (2.0f);
		player.intensity = 0;
		txt.gameObject.SetActive (false);
		controller.GetComponent<FirstPersonController>().enabled = true;
		controller.GetComponent<PlayerController> ().enabled = true;

		Destroy (this.gameObject);

	}
}

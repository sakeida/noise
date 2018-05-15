using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDflag : MonoBehaviour {
	public GameObject came;
	 GlitchFx player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "player") {
			
			Destroy (this.gameObject);
			PlayerController.FLAG++;
			player=came.GetComponent<GlitchFx> ();
			player.intensity = 0.5f;
			StartCoroutine ("NOISE");
		}
	}
	IEnumerator NOISE(){
		yield return new WaitForSeconds (1f);
		came.GetComponent<GlitchFx>().enabled= false;

	}
}

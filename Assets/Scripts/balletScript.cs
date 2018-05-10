using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balletScript : MonoBehaviour {
	public GameObject explosion;
	public GameObject ex;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag != "player"||col.gameObject.tag!="MainCamera") {
			explosion.gameObject.SetActive (true);
			ex.gameObject.SetActive (true);
			ball.gameObject.SetActive (false);


		}
	}

	
/*	IEnumerator Destrooy(){
		yield return new WaitForSeconds (0.4f);
		Destroy (this.gameObject);
	}
*/
	/*void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Enemy"){
			col.SendMessage ("Damage");


}
	}*/
}
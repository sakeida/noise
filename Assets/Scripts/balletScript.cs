using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balletScript : MonoBehaviour {
	public GameObject explosion;
	public GameObject ex;
	public GameObject ball;


	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody>().velocity = transform.forward * 50;

		Destroy (this.gameObject, 5f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag != "player"&&col.gameObject.tag!="MainCamera"&&col.gameObject.tag!="BOSS"&&col.gameObject.tag!="misille") {
			
			explosion.gameObject.SetActive (true);
			ex.gameObject.SetActive (true);
			ball.gameObject.SetActive (false);
			ex.GetComponent<SphereCollider>().enabled = true;

			StartCoroutine ("Destrooy");
			//Destroy (this.gameObject);
			//Instantiate (explosion, transform.position, transform.rotation);
		}
	}

	
	IEnumerator Destrooy(){
		yield return new WaitForSeconds (0.4f);
		Destroy (this.gameObject);
	}

	/*void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Enemy"){
			col.SendMessage ("Damage");


}
	}*/
}
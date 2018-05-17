using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generaterHP : MonoBehaviour {



	public GameObject key;
	public GameObject explosion;

	int GeneHP=10;

	//

	// Use this for initialization
	void Start () {
		
	
	}

	// Update is called once per frame
	void Update () {
		

	}
	void Damage(){
		GeneHP--;


		if (GeneHP == 0) {
			Destroy (this.gameObject);
			key.gameObject.SetActive (true);
			Instantiate (explosion, transform.position, transform.rotation);
		}
	}

}

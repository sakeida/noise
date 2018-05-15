using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botton : MonoBehaviour {

	public GameObject cubs;
	public GameObject txt;

	int enemyHP=1;

	//

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		
	}
	void Damage(){
		enemyHP--;


		if (enemyHP == 0) {
			Destroy (gameObject);
			cubs.SetActive (true);
			txt.SetActive (true);

		}
	}


		}
	
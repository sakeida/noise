using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHP : MonoBehaviour {
	int enemyHP=30;
	public GameObject boss;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){}
	void Damage(){
			enemyHP--;


			if (enemyHP == 0) {
			Destroy (boss.gameObject);

			}
		}

}

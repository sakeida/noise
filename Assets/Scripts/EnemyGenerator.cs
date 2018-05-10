using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Generate", 0, 5);
		
	}
	void Generate(){
		Instantiate (enemy, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

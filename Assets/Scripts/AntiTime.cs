using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiTime : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "timeCube") {
			col.GetComponent<TimeBody> ().enabled = false;
		}
	
	}
}

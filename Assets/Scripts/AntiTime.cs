using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiTime : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "timeCube") {
			col.GetComponent<TimeBody> ().enabled = false;
		}
	}
	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "timeCube") {
			col.GetComponent<TimeBody> ().enabled = true;
		}
	}
}

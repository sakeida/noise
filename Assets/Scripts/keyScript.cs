using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="player"){
			col.SendMessage ("getKey");
			Destroy (this.gameObject);

		}
	}
	/*IEnumerator noise(){
		PlayerController.noiseFlag=true;
}*/
}

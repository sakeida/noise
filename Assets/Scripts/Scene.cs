using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
	

public class Scene : MonoBehaviour {

	public string nextstage;
	public int restartpoint;

	// Use this for initialization
	void Start () {
		PlayerController.stage = restartpoint;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "player") {
			SceneManager.LoadScene (nextstage);
			//Destroy (this.gameObject);
		}



	}
}

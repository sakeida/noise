using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)){
			PlayerController.playerHP = 3;
		if (PlayerController.stage == 0)
			SceneManager.LoadScene ("Scene-0");
		else if (PlayerController.stage == 1)
			SceneManager.LoadScene ("Stage1");
		else if (PlayerController.stage == 2)
			SceneManager.LoadScene ("Stage2");
		else if (PlayerController.stage == 3)
			SceneManager.LoadScene ("Stage3");
		else
			SceneManager.LoadScene ("Stage4");
	}
			if(Input.GetKeyDown(KeyCode.B)){
			PlayerController.playerHP = 3;
		SceneManager.LoadScene ("Title");
	}

}
			}

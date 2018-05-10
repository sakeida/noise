using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public Camera camera;
	public AudioSource gunSound;
	public static int key;
	public static int playerHP=20;
	public static int Ammo=30;   
	public static int stage;
	public static int FLAG=0;
	public GameObject ball;
		public Text ammoTxT;
		public Text HPtxt;
		


		// Use this for initialization
		void Start () {
			key = 0;
			
	Cursor.lockState = CursorLockMode.Locked;
			
		}
		
		// Update is called once per frame
		void Update () {
			ammoTxT.text = Ammo.ToString ();
			HPtxt.text = "HP:"+playerHP.ToString ();
			
			if (Input.GetMouseButtonDown (0)&&Ammo>0) {//ココ
				Shot ();
				gunSound.Play ();
				Ammo--;      //ココ！
			}

					






		if(Input.GetKeyDown(KeyCode.F)){
			Time.timeScale = 0.25f;
		}
		if (Input.GetKeyUp (KeyCode.F)) {
			Time.timeScale = 1;
		}
			




			
		if (playerHP == 0)
			SceneManager.LoadScene ("GameOver");

		if (Input.GetKey (KeyCode.R) ) {//ココからした
			
				Ammo = 30;
				
		}

				





	}

	void playerDamage(){
		playerHP--;


	}
	void getFLAG(){
		FLAG++;
	}
	void getKey(){
		key++;
	}
	void playerheal(){
		playerHP++;


	}
	void getAmmo(){
		

	}
	void Shot(){
		/*int distance = 15;
		Vector3 center = new Vector3 (Screen.width / 2, Screen.height / 2, 0);
		Ray ray = camera.ScreenPointToRay (center);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, distance)) {
			if (hitInfo.collider.tag == "Enemy") {
				hitInfo.collider.SendMessage ("Damage");
			}


			//Debug.DrawLine (ray.origin, hitInfo.point, Color.red);
			//Debug.Log("name :"+hitInfo.collider.name);
		}

*/
		Vector3 pos = transform.position + transform.TransformDirection(Vector3.forward)*0.55f;		
		GameObject ball_ins = Instantiate(ball , pos , Quaternion.identity) as GameObject;		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 direction = ray.direction;
		ball_ins.GetComponent<Rigidbody> ().AddForce (direction.normalized * 2000);
		Destroy (ball_ins.gameObject, 5f);


	}
}
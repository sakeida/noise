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
	bool noiseFlag=false;
	bool shotinterval=false;
	public GameObject ball;
		public Text ammoTxT;
		public Text HPtxt;


	public GameObject muzzle; 



		// Use this for initialization
		void Start () {
			key = 0;
			
	Cursor.lockState = CursorLockMode.Locked;
			
		}
		
		// Update is called once per frame
		void Update () {
			ammoTxT.text = Ammo.ToString ();
			HPtxt.text = "HP:"+playerHP.ToString ();
			
		if (Input.GetMouseButtonDown (0)&&Ammo>0&&!shotinterval) {//ココ
				Shot ();
				gunSound.Play ();
				Ammo--;      //ココ！
			shotinterval=true;
			StartCoroutine ("interval");
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

		//Vector3 pos = transform.position + transform.TransformDirection(Vector3.forward)*0.55f;		
		//GameObject ball_ins = Instantiate(ball , pos , Quaternion.identity) as GameObject;		
		//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Vector3 direction = ray.direction;
		//ball_ins.GetComponent<Rigidbody> ().AddForce (direction.normalized * 1800);
		//ball_ins.GetComponent<Rigidbody> ().AddForce (direction* 1800);
		//GameObject obj = Instantiate(ball, new Vector3 (muzzle.transform.position.x,muzzle.transform.position.y+0.5f,muzzle.transform.position.z), muzzle.transform.rotation) as GameObject;
		//飛ばす方向は muzzle オブジェクトのz軸方向の向き ( transform.forward )
		//obj.GetComponent<Rigidbody>().velocity = transform.forward * 150;

		//Instantiate (ball, muzzle.transform.position, new Vector3(muzzle.transform.rotation.w,rotaX.transform.rotation.x,rotaY.transform.rotation.y,muzzle.transform.rotation.z));


//		Vector3 pos = transform.position + transform.TransformDirection(Vector3.forward)*0.55f;		
//		GameObject ball_ins = Instantiate(ball , pos , Quaternion.identity) as GameObject;		
//		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//		Vector3 direction = ray.direction;
//		ball_ins.GetComponent<Rigidbody> ().AddForce (direction.normalized * 10);
//		Destroy (ball_ins.gameObject, 5f);

		Instantiate (ball, muzzle.transform.position, muzzle.transform.rotation);
	
	}
	IEnumerator interval(){
		yield return new WaitForSeconds (0.9f);
		shotinterval = false;
	}
}
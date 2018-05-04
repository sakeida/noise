using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public Camera camera;
	public AudioSource gunSound;
	public static int key;
	public static int playerHP=3;
	public static int Ammo=30;   
	public static int stage;
		public Text ammoTxT;
		public Text HPtxt;
		/*bool isRewinding = false;
		public float recordTime;
		List<PointinTime>pointsInTime;
		Rigidbody rb;
		*/	


		// Use this for initialization
		void Start () {
			key = 0;
			/*pointsInTime=new List<PointinTime>();
			rb = GetComponent<Rigidbody> ();
	*/
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
			/*if (Input.GetMouseButtonDown (1)) {
				StartRewinding ();
			}
			if(Input.GetMouseButtonUp(1)){
				StopRewinding();
			}*/
				
					






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
	/*void FixUpdate(){
		if (isRewinding)
			Rewinding();
		else
			Record();

	}
	void Record(){
		if (pointsInTime.Count > Mathf.Round (recordTime / Time.fixedDeltaTime))
			pointsInTime.RemoveAt (pointsInTime.Count - 1);


		pointsInTime.Insert (0, new PointinTime(transform.position,transform.rotation));

	}
	void Rewinding ()
	{
		if (pointsInTime.Count > 0) {
			PointinTime pointIntime = pointsInTime [0];
			transform.position = pointIntime.position;
			transform.rotation = pointIntime.rotation;
			pointsInTime.RemoveAt (0);
		} else
			StopRewinding ();
	}

	public void StartRewinding(){
		isRewinding = true;
		rb.isKinematic = true;
	}
	public void StopRewinding(){
		isRewinding = false;
		rb.isKinematic = false;
	}
*/
	void playerDamage(){
		playerHP--;


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
		int distance = 15;
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



	}
}
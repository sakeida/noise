using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour {
	public GameObject explosion;
	public GameObject ex;
	public GameObject obj;
	void Update () {
		GameObject player = GameObject.Find ("FPSController");
		float speed = 5.0f;
		float step = Time.deltaTime * speed;
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
		transform.LookAt(player.transform);


	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag!="BOSS"&&col.gameObject.tag!="Enemy") {
			explosion.gameObject.SetActive (true);
			obj.gameObject.SetActive (false);
			StartCoroutine ("Destrooy");
			ex.GetComponent<SphereCollider>().enabled = false;

			if(col.gameObject.tag=="player")
				col.SendMessage ("playerDamage");
			
		}

		}
	IEnumerator Destrooy(){
		yield return new WaitForSeconds (0.5f);
		Destroy (this.gameObject);
	}
}
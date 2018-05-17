using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossScript : MonoBehaviour {
	public Transform target;
	NavMeshAgent agent;
	public GameObject BossBullet;
	GameObject[] tag;
	bool anime=true;
	int enemyHP=30;
	public Animator ANIME;

	//

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
		tag = GameObject.FindGameObjectsWithTag ("misille");

	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);

			

	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="player"){
			//アニメ処理
			ANIME.SetBool("Attack",true);

			StartCoroutine("Generate");
			agent.speed = 0;



		}
	}
	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "player") {
			ANIME.SetBool ("Attack", false);
			StopCoroutine ("Generate");
			agent.speed = 3.5f;
		}
	}
	IEnumerator  Generate(){
		while (tag.Length < 10) {
			
			Instantiate (BossBullet, transform.position, transform.rotation);

			yield return new WaitForSeconds (1f);
			tag = GameObject.FindGameObjectsWithTag ("misille");

		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossScript : MonoBehaviour {
	public Transform target;
	NavMeshAgent agent;
	int enemyHP=30;

	//

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (target.position);

	}
	void Damage(){
		enemyHP--;


		if (enemyHP == 0) {
			Destroy (this.gameObject);

		}
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="player"){
			col.SendMessage ("playerDamage");
			Destroy (this.gameObject);

		}
	}
}
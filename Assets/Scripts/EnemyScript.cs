using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//
using UnityEngine.UI;
//

public class EnemyScript : MonoBehaviour {
	//public Transform target;
	//NavMeshAgent agent;
	int enemyHP=3;
	//
	//public Slider slider;

	//

	// Use this for initialization
	void Start () {
		/*GameObject player = GameObject.Find ("FPSController");
		target = player.transform;
		agent = GetComponent<NavMeshAgent> ();*/
	}
	
	// Update is called once per frame
	void Update () {
	//	agent.SetDestination (target.position);
		
	}
	void Damage(){
		enemyHP--;
		//
	//	slider.value-=1;
		//

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

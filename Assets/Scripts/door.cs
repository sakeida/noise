using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	public GameObject thedoor;
	public int must;

void OnTriggerEnter ( Collider obj  ){
		if (PlayerController.key >=must&&obj.gameObject.tag=="player") {
			//thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("open");
		}
	}
	void OnTriggerExit ( Collider obj  ){
		if (PlayerController.key >=must&&obj.gameObject.tag=="player") {
			//thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("close");
		}
	}


}
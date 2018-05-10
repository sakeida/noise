using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
	public int must;

void OnTriggerEnter ( Collider obj  ){
		if (PlayerController.key >=must) {
			thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("open");
		}
	}


}
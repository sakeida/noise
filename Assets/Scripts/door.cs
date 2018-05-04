using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;

void OnTriggerEnter ( Collider obj  ){
		if (PlayerController.key >=4) {
			thedoor = GameObject.FindWithTag ("SF_Door");
			thedoor.GetComponent<Animation> ().Play ("open");
		}
	}


}
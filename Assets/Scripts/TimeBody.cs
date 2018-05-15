using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeBody : MonoBehaviour {
	public bool isRewinding = false;
	List<PointInTime>pointsInTime;
	Rigidbody rb;


	void Start () {
		pointsInTime = new List<PointInTime>();
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)){
			startRewind ();
	}
		if (Input.GetMouseButtonUp (1)) {
			stopRewind ();
		}
	}
	void FixedUpdate(){
		if (isRewinding)
			Rewind ();
		else
			Record();
	}
	void Rewind(){
		if (pointsInTime.Count > 0) {
			PointInTime pointInTime = pointsInTime [0];
			transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
			pointsInTime.RemoveAt(0);
		} else {
			//stopRewind ();
			isRewinding=false;
			rb.isKinematic = true;
		}
	}



	void Record(){
		pointsInTime.Insert (0, new PointInTime(transform.position,transform.rotation));
	}


	public void startRewind(){
		isRewinding = true;
		rb.isKinematic = true;
	}
	public void stopRewind(){
		isRewinding = false;
		rb.isKinematic = false;
	}


}
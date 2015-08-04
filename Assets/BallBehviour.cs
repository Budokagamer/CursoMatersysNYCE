using UnityEngine;
using System.Collections;

public class BallBehviour : MonoBehaviour {
		
	Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		Vector3 direction;

		direction = new Vector3(Input.GetAxis("Horizontal"),
		                        0,
		                        Input.GetAxis("Vertical"));
		rb.AddForce(direction);
	}


}



















/*void OnCollisionEnter(Collision collision){
	GetComponent<Renderer>().material.color = Color.red;
}

void OnCollisionExit(Collision collision){
	GetComponent<Renderer>().material.color = Color.yellow;
}

void OnCollisionStay(Collision collision){
	GetComponent<Renderer>().material.color = Color.green;
}


*/



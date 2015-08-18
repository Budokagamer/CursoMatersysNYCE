using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {

	Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}


	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
			rb.AddForce(Vector3.right * 5, 
			            ForceMode.Impulse);

		if(Input.GetKeyDown(KeyCode.Alpha2))
			rb.AddForce(Vector3.left, 
			            ForceMode.Impulse);
	}


}

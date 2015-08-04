using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	public Renderer foco;

	Rigidbody rb;
	bool hasGameStarted;

	void Start(){
		rb = GetComponent<Rigidbody>();
		hasGameStarted = false;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&& !hasGameStarted)
		{
			rb.AddForce(-transform.forward * 10,ForceMode.Impulse);
			hasGameStarted = true;
		}
	}


	void OnTriggerEnter(Collider collider){
		if(collider.name == "LoseVolume"){
			print ("Perdiste");
			foco.material.color = Color.red;
		}
	}
}


using UnityEngine;
using System.Collections;

public class Rebotador : MonoBehaviour {

	public float force = 5;

	void OnCollisionEnter(Collision collision){

		if(collision.gameObject.name == "Ball"){

			Vector3 normal = collision.contacts[0].normal;

			collision.rigidbody.AddForce(-normal * force,ForceMode.Impulse);

			print ("Aventando la pelota");

		}

	}

}

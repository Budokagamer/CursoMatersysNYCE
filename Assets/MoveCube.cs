using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	public float speed = 10;
	public float rotSpeed = 15;

	void Update () {
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");


		//Traslacion
		Vector3 direction = Vector3.forward * z;
		transform.Translate(direction * speed * Time.deltaTime);

		//Rotacion
		transform.Rotate(Vector3.up , x * Time.deltaTime * rotSpeed);

		//Escala
		//float scale = Mathf.Abs(z);

		//transform.localScale = new Vector3(1 + scale,1 + scale,1 + scale);
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "Ball"){
			collision.rigidbody.AddForceAtPosition(
				-collision.contacts[0].normal* 10, 
				collision.contacts[0].point,
				ForceMode.Impulse);
		}
	}














}

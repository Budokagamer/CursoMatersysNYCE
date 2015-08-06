
using UnityEngine;
using System.Collections;

public class PickingPrimeraVersion : MonoBehaviour {

	Vector3 delta;
	float z;


	void Start(){
		z = Vector3.Distance(Camera.main.transform.position,transform.position);
	}

	void OnMouseDown(){
		print ("Sub-zero");
	}

	
	void OnMouseDrag(){
		//print (Camera.main.ScreenPointToRay(Input.mousePosition).origin);
		transform.position = Camera.main.transform.position + 
							Camera.main.ScreenPointToRay(Input.mousePosition).direction*z ;

	}

	void OnMouseOver(){
		print ("Sobre Sub-zero");
	}

}

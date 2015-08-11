using UnityEngine;
using System.Collections;

public class BoneBehaviour : MonoBehaviour {

	/*void OnBecameInvisible(){
		Destroy(gameObject);
	}*/

	void Start(){
		Invoke("DestroyMe",2);
	}


	void DestroyMe(){
		Destroy(gameObject);
	}
}

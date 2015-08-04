using UnityEngine;
using System.Collections;

public class ControlPaleta : MonoBehaviour {

	public Animator paletaIzquierda, paletaDerecha;
	
	void Update () {

		if(Input.GetKeyDown(KeyCode.Z)){
			paletaIzquierda.SetTrigger("Activate");
		}

		if(Input.GetKeyDown(KeyCode.M)){
			paletaDerecha.SetTrigger("Activate");
		}
	}
}

using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	public Light lamp;


	void OnMouseDown(){
		lamp.enabled = !lamp.enabled;
	}
}

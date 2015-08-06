using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	public LightStrobe strobe;

	public Light lamp;

	void OnMouseDown(){

		lamp.enabled = !lamp.enabled;


		if(strobe.active)
			strobe.EndStrobe();
		else
			strobe.StartStrobe();
	}
}

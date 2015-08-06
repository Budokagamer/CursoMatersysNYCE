using UnityEngine;
using System.Collections;

public class LightStrobe : MonoBehaviour {

	Light lamp;

	public bool active;

	void Start(){
		lamp = GetComponent<Light>();
		active = false;
		lamp.enabled = false;
	}

	public void StartStrobe () {
		StartCoroutine("Strobe");
		
		active = true;
	}

	IEnumerator Strobe(){
		lamp.enabled = true;
		yield return new WaitForSeconds(0.1f);
		lamp.enabled = false;
		yield return new WaitForSeconds(0.1f);
		StartCoroutine("Strobe");
	}

	public void EndStrobe () {
		active = false;
		lamp.enabled = false;
		StopCoroutine("Strobe");
	}

}

using UnityEngine;
using System.Collections;

public class LightBehaviour : MonoBehaviour {

	public float speed = 5;

	Light lightSource;
	float lightIntensity = 4;
	
	void Start () {
		lightSource = GetComponent<Light>();
		lightSource.intensity = lightIntensity;
	}

	void Update () {
		//Modificando el valor de lightIntensity
		lightIntensity += Input.GetAxis("Mouse ScrollWheel") * speed;

		//Limitando el valor lightIntensity entre 0 y 8
		lightSource.intensity = Mathf.Clamp(lightIntensity,0f,8f);

		/*if(Input.GetMouseButtonDown(0))
			lightSource.enabled = true;
		else if(Input.GetMouseButtonDown(1))
			lightSource.enabled = false;*/

		if(Input.GetMouseButtonDown(0))
			lightSource.enabled = !lightSource.enabled;
	}
}
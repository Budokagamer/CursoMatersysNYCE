using UnityEngine;
using System.Collections;

public class FireBehaviour : MonoBehaviour {

	ParticleSystem particle;

	
	void Start(){
		particle = GetComponent<ParticleSystem>();

	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			if(particle.isPlaying)
			{
				particle.Stop();
			}
			else
			{
				particle.Play();
			}
		}
	}
}

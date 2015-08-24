using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	AudioSource audioSource;
	AudioClip clip;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
			if(!audioSource.isPlaying)
				audioSource.Play();

		if(Input.GetKeyDown(KeyCode.A))
			if(audioSource.isPlaying)
				audioSource.Stop();

		if(Input.GetKeyDown(KeyCode.B))
			if(audioSource.isPlaying)
				audioSource.Pause();
	}


}

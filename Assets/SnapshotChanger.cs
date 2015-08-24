using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SnapshotChanger : MonoBehaviour {

	public AudioMixerSnapshot stress;
	
	void Update () {
		if(Input.GetMouseButtonDown(0))
			stress.TransitionTo(5);
	}
}

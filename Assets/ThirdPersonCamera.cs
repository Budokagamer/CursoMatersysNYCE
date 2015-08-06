using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	[Range(0,10)]
	public float smooth = 2;

	Transform lookAt;

	// Use this for initialization
	void Start () {
		lookAt = GameObject.Find("LookAt").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp(transform.position,
		                                  lookAt.position,
		                                  Time.deltaTime * smooth);

		transform.rotation = lookAt.rotation;
	}
}

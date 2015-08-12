using UnityEngine;
using System.Collections;

public class BoxerAnimatorController : MonoBehaviour {

	Animator animator;
	bool isDancing;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		isDancing = false;
		animator.SetBool("Dancing",isDancing);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.K)){
			isDancing = !isDancing;
			animator.SetBool("Dancing",isDancing);
		}
	}
}

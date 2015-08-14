using UnityEngine;
using System.Collections;

public class TimController : MonoBehaviour {

	Animator animator;
	float xdir;
	public float speed = 5;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		xdir = 1;
	}


	public void Algo(){
		print ("Hola Mundo");
	}

	// Update is called once per frame
	void Update () {
		animator.SetFloat("Speed",
          Mathf.Abs(Input.GetAxis("Horizontal")));

		if(Input.GetAxis("Horizontal") > 0)
			xdir = 1;
		else if(Input.GetAxis("Horizontal") < 0)
			xdir = -1;

		transform.localScale = new Vector2(xdir,1);
		transform.Translate(
			Input.GetAxis("Horizontal") * Time.deltaTime * speed
		                    ,0,0);
	}


}

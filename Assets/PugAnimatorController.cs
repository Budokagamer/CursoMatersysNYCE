using UnityEngine;
using System.Collections;

public class PugAnimatorController : MonoBehaviour {

	public Transform mano;
	public GameObject hueso;

	Animator animator;
	int life = 5;
	
	void Start () {
		animator = GetComponent<Animator>();
		animator.SetInteger("Life",life);
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			animator.SetBool("IsInSlot",false);
			animator.SetTrigger("Release");
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			animator.SetBool("IsInSlot",true);
			animator.SetTrigger("Release");
		}

		//print(animator.GetBool("IsInSlot"));

		if(Input.GetKeyDown(KeyCode.LeftArrow) &&
		   animator.GetCurrentAnimatorStateInfo(0).IsName("Lanzar")){
			life --;
			life = Mathf.Clamp(life,0,5);
			animator.SetInteger("Life",life);
		}

		if(Input.GetKeyDown(KeyCode.Alpha3)){
			animator.SetTrigger("Changed");
		}

		if(Input.GetKeyDown(KeyCode.Alpha4)){
			animator.SetTrigger("Win");
		}
	}

	public void ThrowEvent(){
		print ("Lanzando hueso");
		GameObject o = Instantiate(hueso,mano.position,mano.rotation) 
			as GameObject;
		o.GetComponent<Rigidbody>().AddForce(mano.right * 10, ForceMode.Impulse);
	}
}

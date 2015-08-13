using UnityEngine;
using System.Collections;

public class IKManager : MonoBehaviour {

	public Transform a,b;

	Animator animator;

	void Start(){
		animator = GetComponent<Animator>();
	}

	void OnAnimatorIK(){
		//Configurar los pesos
		animator.SetLookAtWeight(0.75f);
		animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
		animator.SetIKPositionWeight(AvatarIKGoal.LeftHand,1f);

		float aDist = Vector3.Distance(transform.position, a.position);
		float bDist = Vector3.Distance(transform.position, b.position);

		Vector3 midPoint;
		if(aDist <= bDist){
			midPoint = a.position;
		}
		else{
			midPoint = b.position;
		}

		//Vector3 midPoint = (a.position + b.position)/2f;

		//Asignar la metas
		animator.SetLookAtPosition(midPoint);
		animator.SetIKPosition(AvatarIKGoal.RightHand, a.position);
		animator.SetIKPosition(AvatarIKGoal.LeftHand, b.position);
	}
}

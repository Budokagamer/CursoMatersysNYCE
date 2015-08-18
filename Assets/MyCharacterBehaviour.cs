using UnityEngine;
using System.Collections;

public class MyCharacterBehaviour : MonoBehaviour {

	public LifeBarBehaviour lifeBar;
	public Renderer model;

	Animator animator;

	void Start(){
		animator = GetComponent<Animator>();
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.name == "Bullet"){
			print ("Bajar vida");
			lifeBar.DecreaseLife();
			animator.SetInteger("Damage",Random.Range(1,2));
			StartCoroutine(DamageFlash());
			GetComponent<AudioSource>().Play();
		}
	}

	IEnumerator DamageFlash(){
		model.material.color = Color.red;
		yield return new WaitForSeconds(0.1f);
		model.material.color = Color.white;
	}

}

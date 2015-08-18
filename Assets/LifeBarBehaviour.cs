using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeBarBehaviour : MonoBehaviour {

	public Slider slider;
	Image lifeBar;


	void Start(){
		lifeBar = GetComponent<Image>();

		//StartCoroutine("DecreaseLifeTime",2f);
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.A)){
			lifeBar.fillAmount = 1;
			lifeBar.color = Color.green;
		}
	}


	public void DecreaseLife(){
		lifeBar.fillAmount -= 0.1f;
		lifeBar.color = Color.Lerp(Color.red, 
		                           Color.green,
		                           lifeBar.fillAmount);
	}

	/*IEnumerator DecreaseLifeTime(float deltaTime){
		yield return new WaitForSeconds(deltaTime);

		lifeBar.fillAmount -= 0.1f;
		lifeBar.color = Color.Lerp(Color.red, 
                                      Color.green,
                                      lifeBar.fillAmount);

		if(lifeBar.fillAmount <= 0)
			yield break;

		print ("Repitiendo corutina");
		StartCoroutine("DecreaseLifeTime",deltaTime);
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.A))
			StopCoroutine("DecreaseLifeTime");
	}*/


	/*void Update(){

		lifeBar.fillAmount = slider.value;
		lifeBar.color = Color.Lerp(Color.red, Color.green,
		                           lifeBar.fillAmount);

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			lifeBar.fillAmount -= 0.1f;
			lifeBar.color = Color.Lerp(Color.red, 
			                           Color.green,
			                           lifeBar.fillAmount);
		}


		if(Input.GetKeyDown(KeyCode.RightArrow)){
			lifeBar.fillAmount += 0.1f;
			lifeBar.color = Color.Lerp(Color.red, 
			                           Color.green,
			                           lifeBar.fillAmount);
		}

	
	}*/


}

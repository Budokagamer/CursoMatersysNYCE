using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	//int sum;
	float time;

	// Use this for initialization
	void Start () {
		//Debug.Log("Hola mundo en el start!!!!!");
		//sum = 0;
		time = 0.0f;
		print ("Start value : " + time);
	}
	
	// Update is called once per frame
	void Update () {
		//print ("Hola mundo en el update!!!!!!");
		time += Time.deltaTime; 
		
		print (time);
	}

}

using UnityEngine;
using System.Collections;


//SUBIR a DROPBOX


public class InputExercise : MonoBehaviour {

	public Renderer c1,c2,c3;

	bool usingController;

	void Update (){
		if(!usingController){
			//Keyboard
			if(Input.GetKeyDown(KeyCode.Alpha1)){
				c1.material.color = Color.red;
			}
			else if(Input.GetKey(KeyCode.Alpha1)){
				c1.material.color = Color.blue;
			}
			else if(Input.GetKeyUp(KeyCode.Alpha1)){	
				c1.material.color = Color.white;
			}

			//MOUSE
			if(Input.GetMouseButtonDown(1)){
				c2.material.color = Color.red;
			}
			else if(Input.GetMouseButton(1)){
				c2.material.color = Color.blue;
			}
			else if(Input.GetMouseButtonUp(1)){	
				c2.material.color = Color.white;
			}

			//Mouse scroll
			float mSW = Input.GetAxis("Mouse ScrollWheel");
			c3.transform.localScale += new Vector3(mSW,mSW,mSW);


			//Mouse position
			print("Mouse pos = " + Input.mousePosition);

			Color finalColor = new Color(0,0,0);

			if(Input.mousePosition.x <= Screen.width/2)
				finalColor.r = 1;
			else
				finalColor.r = 0;

			if(Input.mousePosition.y <= Screen.height/2)
				finalColor.g = 1;
			else
				finalColor.g = 0;

			c3.material.color = finalColor;

			//Botones personalizados
			if(Input.GetButtonDown("Jump"))
				print ("Brincando");

			//MouseX & MouseY
			c3.transform.Translate(Vector3.forward * Input.GetAxis("Mouse Y"));
		}
	}
}

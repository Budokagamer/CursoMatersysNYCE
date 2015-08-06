using UnityEngine;
using System.Collections;

public class Picking : MonoBehaviour {
	
	RaycastHit hit;
	bool onDrag;
	Transform objeto;

	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit)){
				print ("Tocaste "+ hit.transform.name + 
				       " en el punto " + hit.point);
			//	objeto = hit.transform;
				onDrag = true;
			}

		}
	}
}

using UnityEngine;
using System.Collections;

public class VectorExercise : MonoBehaviour {
	
	void Start () {

		Vector3 v1 = new Vector3(1, -4 , 6);
		Vector3 v2 = new Vector3(-5, 3 , 0);	

		print ("R1 : " + (5 * v1));
		print ("R2 : " + (v1 + v2));
		print ("R3 : " + (v1 - v2));

		Vector3 vR = v1 - v2;

		print ("Dist : " + (Vector3.Distance(v1 , v2)));
		print ("Dist v2 : " + vR.magnitude);

		print ("VR normalizado : " + vR.normalized);
		print ("VR normalizado magnitud: " + vR.normalized.magnitude);

		print ("Angulo " + Vector3.Angle(Vector3.up, Vector3.right));
		print ("Punto " + Vector3.Dot(Vector3.up, Vector3.right));


		/*5 * v1 = (1 * 5 , -4 * 5 , 6 * 5) = (5, -20, 30)


		v1 + v2 = (1 + (-5) , -4 + 3, 6 + 0) = (-4,-1,6)
		v1 - v2 = (1 - (-5) , -4 - 3, 6 - 0) = (6,-7,6)
		

		magnitud = raiz cuadrada(6*6 + (-7)*(-7) + 6*6)*/

	}

}

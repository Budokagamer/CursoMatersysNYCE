using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	public GameObject loadingScreen;

	void Start(){
		DontDestroyOnLoad(gameObject);
	}

	public void ChangeToLevel(string level){                    
		StartCoroutine(LoadNewLvl(level));
	}


	IEnumerator LoadNewLvl(string level){
		AsyncOperation async = Application.LoadLevelAsync(level);
		yield return async;
		print ("Cambie de escena");
	}

}

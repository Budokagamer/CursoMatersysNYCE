using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UnityAdsManager : MonoBehaviour {

	void Awake(){
		if (Advertisement.isSupported) {
			Advertisement.Initialize("64222",true);
		} else {
			Debug.Log("Platform not supported");
		}
	}


	public void Show(){
	//if(Advertisement.IsReady())
		Advertisement.Show(null, new ShowOptions {
			resultCallback = result => {
				Debug.Log(result.ToString());
			}
		});
	}


	public void OpenYoutube(){
		Application.OpenURL("http://www.google.com");
	}
}

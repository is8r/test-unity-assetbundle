using UnityEngine;
using System.Collections;
using System;

public class loadAsset : MonoBehaviour {

	void Start () 
	{
		string url = "http://localhost:8000/cube";
		WWW www = new WWW(url);
		StartCoroutine(WaitForReq(www));
	}

	IEnumerator WaitForReq(WWW www)
	{
		yield return www;
		AssetBundle bundle = www.assetBundle;
		if(www.error == null){
			GameObject cube = (GameObject)bundle.LoadAsset("cube");
			Instantiate(cube); 
		}
		else{
			Debug.Log(www.error);
		}
	}
}

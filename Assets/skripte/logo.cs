using UnityEngine;
using System.Collections;

public class logo : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		StartCoroutine ("DisplayScene");
	}
	
	// Update is called once per frame
	IEnumerator DisplayScene(){
		yield return new WaitForSeconds (0.1f);
		Application.LoadLevel ("mainmenu");
	}
}

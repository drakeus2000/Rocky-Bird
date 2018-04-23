using UnityEngine;
using System.Collections;

public class infoscreen : MonoBehaviour {
	
	// Use this for initialization
		void Awake () {
			GetComponent<SpriteRenderer>().enabled = true;
				Time.timeScale = 0;
		}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale ==0 && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))){
				Time.timeScale = 1;
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<infoscreen>().enabled = false;
		}
	}
}

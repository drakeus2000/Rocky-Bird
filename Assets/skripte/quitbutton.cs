using UnityEngine;
using System.Collections;

public class quitbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit();
	}
	void OnMouseDown(){
		// this object was clicked - do something
		Application.Quit();
	}   
}

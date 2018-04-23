using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	
	void OnMouseDown(){
		// this object was clicked - do something
		loadlevel.show();
		Application.LoadLevel("mars_lvl1");
	}   
}

using UnityEngine;
using System.Collections;

public class credits1 : MonoBehaviour {
	
	public Camera mainCam;
	
	void OnMouseDown(){
			mainCam.transform.position = new Vector3 (-12.7f, -1.16f, -10); 
		}
}

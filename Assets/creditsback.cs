using UnityEngine;
using System.Collections;

public class creditsback : MonoBehaviour {

	public Camera mainCam;
	// Use this for initialization
	void OnMouseDown () {
		mainCam.transform.position = new Vector3 (-0.59f, -1.16f, -10);
	}
}

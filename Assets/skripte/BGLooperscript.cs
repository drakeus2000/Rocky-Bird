using UnityEngine;
using System.Collections;

public class BGLooperscript : MonoBehaviour {

	int numBGPanels = 2;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider) {

			Debug.Log ("Triggered: " + collider.name);
	
			float widthofBGObject = ((BoxCollider2D)collider).size.x;

			Vector3 pos = collider.transform.position;

			pos.x += widthofBGObject * numBGPanels;

			collider.transform.position = pos;
	}
}

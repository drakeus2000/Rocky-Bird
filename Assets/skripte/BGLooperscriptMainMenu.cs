using UnityEngine;
using System.Collections;

public class BGLooperscriptMainMenu : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		
		Debug.Log ("Triggered: " + collider.name);
		
		Vector3 pos = collider.transform.position;
		
		pos.x += 30;
		
		collider.transform.position = pos;
	}
}

using UnityEngine;
using System.Collections;

public class title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			transform.position = transform.position + Vector3.right * -2 * Time.deltaTime;
	}
	void OnTriggerEnter2D(Collider2D collider) {
		
		Debug.Log ("Triggered: " + collider.name);
		
		Vector3 pos = gameObject.transform.position;
		
		pos.x = +19.392f;
		
		gameObject.transform.position = pos;
	}
}

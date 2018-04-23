using UnityEngine;
using System.Collections;

public class meteormainmenu : MonoBehaviour {

	public GameObject ExplosionPrefabAvion;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider) {
		Instantiate (ExplosionPrefabAvion, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
		Destroy (collider.gameObject);
		Destroy (gameObject);
	}
}

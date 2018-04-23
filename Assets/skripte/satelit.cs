using UnityEngine;
using System.Collections;

public class satelit : MonoBehaviour {
	

	Vector3 atoranjgen = new Vector3 (0, 2.6f, 0) ;
	// Use this for initialization
	void Start () {

		atoranjgen.x = Random.Range (transform.position.x - 1f, transform.position.x + 1f);
		atoranjgen.y = Random.Range (atoranjgen.y - 1f, atoranjgen.y + 0.8f);
		atoranjgen.z = transform.position.z;
		transform.position = atoranjgen;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

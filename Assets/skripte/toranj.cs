using UnityEngine;
using System.Collections;

public class toranj : MonoBehaviour {

	

	Vector3 atoranjgen = new Vector3 (0, -2.45f, 0) ;
	// Use this for initialization
	void Start () {

		if(gameObject.tag == "Hitler")
			atoranjgen.y = transform.position.y - 2.3f;

		if (gameObject.tag == "duplabrana")
			atoranjgen.y = transform.position.y;

		atoranjgen.x = Random.Range (transform.position.x - 2f, transform.position.x-0.4f);
		transform.position = atoranjgen;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


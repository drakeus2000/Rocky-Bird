using UnityEngine;
using System.Collections;

public class avion : MonoBehaviour {
	
	Vector3 aviongen = new Vector3 (0, 0, 0) ;
	// Use this for initialization
	void Start () {
		aviongen.x = Random.Range (transform.position.x - 1f, transform.position.x + 1f);
		aviongen.y = Random.Range (transform.position.y - 2.5f, transform.position.y + 2.5f);
		aviongen.z = transform.position.z;
		transform.position = aviongen;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


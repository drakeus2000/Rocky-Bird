using UnityEngine;
using System.Collections;

public class BGMove : MonoBehaviour {
	public GameObject player_go;
	// Rigidbody2D player;
	float vel = 2f;

	void Start () {

	//	player = player_go.GetComponent<Rigidbody2D>(); // u slucaju da nadjem nacin kako se proverava da li je dead = true
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (GameObject.FindGameObjectWithTag ("Player").GetComponent<BirdMovement>().dead) 
			vel = 0f;

		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	
	}
}
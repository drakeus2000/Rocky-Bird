using UnityEngine;
using System.Collections;

public class BGGroundmove : MonoBehaviour {

	float vel;
	
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		if (player_go == null) {
			Debug.LogError ("Couldn't find an object with tag 'Player'");
			return;
		}
		
		//	player = player_go.GetComponent<Rigidbody2D>(); // u slucaju da nadjem nacin kako se proverava da li je dead = true
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (GameObject.Find("Player").GetComponent<BirdMovement>().dead) 
			vel = 0f;
		else
			vel = -5f;
		
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
		
	}
}

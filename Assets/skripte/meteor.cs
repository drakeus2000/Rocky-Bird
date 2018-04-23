using UnityEngine;
using System.Collections;

public class meteor : MonoBehaviour {

	// Use this for initialization
	public GameObject ExplosionPrefabToranj;
	public GameObject ExplosionPrefabAvion;

	Transform player;


	public int scoreValue;
	public int scoreHitler;
	public BirdMovement gameControler;


	// Use this for initialization
	void Start () {

		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		player = player_go.transform;

		gameControler = player_go.GetComponent<BirdMovement>();
	}
	
	// Update is called once per frame
		void FixedUpdate () {
			
	}
	void OnTriggerEnter2D(Collider2D collider) {
		if ((gameObject.transform.position.x - player.transform.position.x) > 12f) {
			Destroy (gameObject);
			return;
		}
		else if (collider.tag != "Finish") {
			if(collider.tag == "Toranj"){
				Instantiate (ExplosionPrefabToranj, new Vector3 (collider.transform.position.x, collider.transform.position.y, collider.transform.position.z), Quaternion.identity);
				Destroy (collider.gameObject);
				gameControler.AddScore (scoreValue);
				}
			else if(collider.tag == "Avion"){
				Instantiate (ExplosionPrefabAvion, new Vector3 (collider.transform.position.x, collider.transform.position.y, collider.transform.position.z), Quaternion.identity);
				Destroy (collider.gameObject);
				gameControler.AddScore (scoreValue);}
			else if(collider.tag == "Hitler"){
				Instantiate (ExplosionPrefabAvion, new Vector3 (collider.transform.position.x, collider.transform.position.y, collider.transform.position.z), Quaternion.identity);
				Destroy (collider.gameObject);
				gameControler.AddScore (scoreHitler);}
			Destroy (gameObject);
		} 
	}
}

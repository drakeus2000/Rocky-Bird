using UnityEngine;
using System.Collections;

public class EnemyPass : MonoBehaviour {

	public int scoreValue;
	public BirdMovement gameControler;
	// Use this for initialization
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("Player");
		if (gameControllerObject != null)
		{
			gameControler = gameControllerObject.GetComponent<BirdMovement>();
		}
	}
	void OnTriggerEnter2D (Collider2D collider){
		if (collider.gameObject.tag != "Meteor" && collider.gameObject.layer != 12)
		gameControler.AddScore (scoreValue);
		Destroy (collider.gameObject);
	}
}
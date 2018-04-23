using UnityEngine;
using System.Collections;

public class meteorgenerisanje : MonoBehaviour {
	
	// Use this for initialization
	public GameObject protivnik1;
	
	Vector3 meteor1;
	Vector3 meteor2;
	Vector3 meteor3;
	Vector3 meteor4;
	
	// Use this for initialization
	Transform player;
	
	void Start () {
		
		InvokeRepeating("CreateObstacle", 6f, 3.8f);
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		player = player_go.transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		meteor1 = new Vector3 (player.position.x + 18f, -0.85f, -1);
		meteor2 = new Vector3 (player.position.x + 18.3f, -1.1f, -1);
		meteor3 = new Vector3 (player.position.x + 18.6f, -2f, -1);
		meteor4 = new Vector3 (player.position.x + 19f, -2.5f, -1);
		
	}
	void CreateObstacle()
	{
		if (GameObject.Find ("Player").GetComponent<BirdMovement> ().dead) 
			return;
		int randomprotivnikkaunter = Random.Range (1,5);
		
		if (randomprotivnikkaunter == 1) {
			Instantiate (protivnik1, meteor1, Quaternion.identity);
		}
		if (randomprotivnikkaunter == 2) {
			Instantiate (protivnik1, meteor1, Quaternion.identity);
			Instantiate (protivnik1, meteor2, Quaternion.identity);
		}
		if (randomprotivnikkaunter == 3) {
			Instantiate (protivnik1, meteor1, Quaternion.identity);
			Instantiate (protivnik1, meteor2, Quaternion.identity);
			Instantiate (protivnik1, meteor3, Quaternion.identity);
		}
		if (randomprotivnikkaunter == 4) {
			Instantiate (protivnik1, meteor1, Quaternion.identity);
			Instantiate (protivnik1, meteor2, Quaternion.identity);
			Instantiate (protivnik1, meteor3, Quaternion.identity);
			Instantiate (protivnik1, meteor4, Quaternion.identity);
		}
	}
}

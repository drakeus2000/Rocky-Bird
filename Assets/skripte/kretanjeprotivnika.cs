using UnityEngine;
using System.Collections;

public class kretanjeprotivnika : MonoBehaviour {

	    Vector3 mesto;
	static float vreme = 9f;

		
	Transform player;

		public GameObject protivnik1;
		public GameObject protivnik2;
		public GameObject protivnik3;
		public GameObject protivnik4;
		public GameObject protivnik5;
		public GameObject protivnik6;

		
		// Pokusaj generisanja novih protivnika

	void Start()
	{
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		player = player_go.transform;

		InvokeRepeating("CreateObstacle", vreme, 1.6f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		mesto = new Vector3 (player.position.x + 17f, -1, -1);

	}

	void CreateObstacle()
	{
		if (GameObject.Find ("Player").GetComponent<BirdMovement> ().dead) 
			return;
		int randomprotivnikkaunter = Random.Range (1,113);

		if ((randomprotivnikkaunter > 1) && (randomprotivnikkaunter < 20))
			Instantiate (protivnik2, mesto, Quaternion.identity);
		if ((randomprotivnikkaunter >= 20) && (randomprotivnikkaunter < 40))
			Instantiate(protivnik3,mesto,Quaternion.identity);
		if ((randomprotivnikkaunter >= 40) && (randomprotivnikkaunter < 60)) {
			Instantiate (protivnik6, mesto, Quaternion.identity);
			Instantiate (protivnik1, mesto, Quaternion.identity);
		}
		if ((randomprotivnikkaunter >= 60) && (randomprotivnikkaunter < 83)) {
			Instantiate (protivnik3, mesto, Quaternion.identity);
			Instantiate (protivnik3, mesto, Quaternion.identity);
		}
		if ((randomprotivnikkaunter >= 83) && (randomprotivnikkaunter < 95)) 
			Instantiate (protivnik4, mesto, Quaternion.identity);

		if ((randomprotivnikkaunter >= 95) && (randomprotivnikkaunter < 101)) 
			Instantiate (protivnik5, mesto, Quaternion.identity);

		if ((randomprotivnikkaunter >= 101) && (randomprotivnikkaunter < 105)) { 
			Instantiate (protivnik6, mesto, Quaternion.identity);
			Instantiate (protivnik6, mesto, Quaternion.identity);
		}

		if ((randomprotivnikkaunter >= 105)) {
			Instantiate (protivnik6, mesto, Quaternion.identity);
			Instantiate (protivnik6, mesto, Quaternion.identity);
			Instantiate (protivnik6, mesto, Quaternion.identity);
		}
	}
	public void Beenthere(){
		vreme = 2.5f;
	}
	public void ispravak (){
		vreme = 9f;
	}
}





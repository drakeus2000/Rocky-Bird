using UnityEngine;
using System.Collections;

public class MainMenuPlane : MonoBehaviour {

	public GameObject ExplosionPrefabAvion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		
		transform.position = transform.position + Vector3.right * -2f * Time.deltaTime;
	
	}
}

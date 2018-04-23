using UnityEngine;
using System.Collections;

public class CameraTracksPlayer : MonoBehaviour {

	Transform player;

	public static bool beenthere1 = false;
	Vector3 beentherevec;

	float offsetX;
	// Use this for initialization
	void Awake(){
		if (Application.loadedLevel == 1)
			beenthere1 = false;
		if (beenthere1) {
			beentherevec = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
			beentherevec.x += 31f;
			transform.position = beentherevec;
			}
		}
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		if (player_go == null) {
			Debug.Log ("Cannot find player");
			return;
		}
	
		player = player_go.transform;

		offsetX = transform.position.x - player.position.x;

	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			transform.position = pos;
			}
	}
	public void ToggleMusic (bool checkmuzika){
		if (checkmuzika == true)
			AudioListener.pause = false;
		if (checkmuzika == false)
			AudioListener.pause = true;
	}
	public void Beenthere(){
		beenthere1 = true;
	}
}
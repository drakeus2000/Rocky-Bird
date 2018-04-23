using UnityEngine;
using System.Collections;

public class musicoff : MonoBehaviour {

	public CameraTracksPlayer soundoff;
	public GameObject SoundOffbutton;

	// Use this for initialization
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("MainCamera");
		if (gameControllerObject != null)
		{
			soundoff = gameControllerObject.GetComponent<CameraTracksPlayer>();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		soundoff.ToggleMusic (false);
		Instantiate (SoundOffbutton, new Vector3 (transform.position.x,transform.position.y, transform.position.z), Quaternion.identity);
		Destroy (gameObject);
	}
}

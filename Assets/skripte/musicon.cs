using UnityEngine;
using System.Collections;

public class musicon : MonoBehaviour {

	public CameraTracksPlayer soundoff;
	public GameObject SoundOnbutton;
	
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
		soundoff.ToggleMusic (true);
		Instantiate (SoundOnbutton, new Vector3 (transform.position.x,transform.position.y, transform.position.z), Quaternion.identity);
		Destroy (gameObject);
	}
}

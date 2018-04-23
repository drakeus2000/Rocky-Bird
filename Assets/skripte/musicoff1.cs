using UnityEngine;
using System.Collections;

public class musicoff1 : MonoBehaviour {

	// Use this for initialization
	public AudioSource musicPlayer;
	
	public void ToggleAudio () {
		if (musicPlayer.isPlaying)
			musicPlayer.Stop ();
		else
			musicPlayer.Play ();
	}
}

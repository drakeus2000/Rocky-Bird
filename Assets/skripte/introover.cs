using UnityEngine;
using System.Collections;

public class introover : MonoBehaviour {

	void OnTriggerEnter2D (){
		GameObject Ptica = GameObject.Find("Player");
		BirdMovement pticascript = (BirdMovement)Ptica.GetComponent (typeof(BirdMovement));
		pticascript.Beenthere();

		GameObject kamera = GameObject.Find ("Main Camera");
		CameraTracksPlayer kamerascript = (CameraTracksPlayer)kamera.GetComponent (typeof(CameraTracksPlayer));
		kamerascript.Beenthere();

		GameObject protivnik = GameObject.Find("Protivnik");
		kretanjeprotivnika protivnikscript = (kretanjeprotivnika)protivnik.GetComponent (typeof(kretanjeprotivnika));
		protivnikscript.Beenthere();

		GameObject cleanup = GameObject.Find ("HumanCity");
		if (cleanup != null)
		cleanup.GetComponent<ExplosionTower>().enabled = true;
	}
}

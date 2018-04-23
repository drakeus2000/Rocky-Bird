using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour {

	bool paused = false;

	static public musicoff1 musicoff2;

	public Texture2D controlTexture;
	public GUIStyle PAUSE;
	public GUIStyle RESTART;
	public GUIStyle MAINMENU;
	public GUIStyle MUSIC;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
			OnMouseDown ();
	}

	void OnMouseDown(){

		if (Time.timeScale == 1f)
		paused = togglePause ();
	}

	void OnGUI()
	{
		if (paused) {

			GUI.Box (new Rect (0, Screen.height/6, Screen.width, Screen.height), controlTexture);
			if (GUI.Button (new Rect (Screen.width / 5.32f, Screen.height / 2.99f, Screen.width / 1.6f, Screen.height / 5.9f),"", PAUSE))
				paused = togglePause ();
			if (GUI.Button (new Rect (Screen.width / 5.32f, Screen.height / 2.26f, Screen.width / 1.6f, Screen.height / 8f), "", RESTART))
				Application.LoadLevel ("mars_lvl1");
			if (GUI.Button (new Rect (Screen.width / 3.75f, Screen.height / 1.85f, Screen.width / 2.2f, Screen.height / 8f),"", MAINMENU)){
				loadlevel.show();
				GameObject Ptica = GameObject.Find("Player");
				BirdMovement pticascript = (BirdMovement)Ptica.GetComponent (typeof(BirdMovement));
				pticascript.ispravak();
				GameObject protivnik = GameObject.Find("Protivnik");
				kretanjeprotivnika protivnik1 = (kretanjeprotivnika)protivnik.GetComponent (typeof(kretanjeprotivnika));
				protivnik1.ispravak();
				Time.timeScale = 1f;
				Application.LoadLevel (1);}
			if (GUI.Button (new Rect (Screen.width / 1.45f, Screen.height / 1.5f, Screen.width / 3.2f, Screen.height / 7), "", MUSIC)){
				musicoff2 = GameObject.Find("CalltoAdventure").GetComponent<musicoff1>();
				musicoff2.ToggleAudio ();
		}
		}
	}

	bool togglePause()
	{
		if(Time.timeScale == 0f)
		{
			Time.timeScale = 1f;
			return(false);
		}
		else 
		{
			Time.timeScale = 0f;
			return(true);    
		}
	}
}
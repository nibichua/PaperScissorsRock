using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
	public HandControls sc;
	int switchmusic1 = 5;
	public AudioSource music1;
	public AudioSource sfx;
	public AudioSource music2;
	int switchmusic2 = 10;
	private bool tmp;

	// Use this for initialization
	void Start () {
		music2.Stop ();
		sfx.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((sc.score % switchmusic2) == 0 && sc.score != 0) {
			if (!music1.isPlaying) {
				music2.Pause ();
				music1.Play ();
				sfx.Play ();
				sfx.loop = false;
				//music2.enabled = false;
				//music1.enabled = true;
			}
		} else if ((sc.score % switchmusic1) == 0 && sc.score != 0) {
			if (!music2.isPlaying) {
				music2.Play ();
				music1.Pause ();//music1.Stop();
				//sfx.enabled = true;
				sfx.Play ();
				sfx.loop = false;
				//sfx.Play ();
				//music2.enabled = true;
				//music2.loop = true;
			}
		} 
	}
}

using UnityEngine;
using System.Collections;

//the script will mute a sound
public class SoundMute : MonoBehaviour {

	public static int mute; //static integer to mute sound

	void Update(){

		if (StartPage.mute == 0) {
			GetComponent<AudioSource>().mute = true;	
		}
		if (StartPage.mute == 1) {
			GetComponent<AudioSource>().mute = false;	
		}

	}
}

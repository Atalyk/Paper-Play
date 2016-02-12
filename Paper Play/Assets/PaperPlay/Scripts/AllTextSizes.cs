using UnityEngine;
using System.Collections;

public class AllTextSizes : MonoBehaviour {

	//All text sizes for different GUI texts
	
	void Update () {

		//change the size of guitext with tag "GameOver"
		//GameOver text appears when ball is destroyed
		if (GetComponent<GUIText>().tag == "GameOver") {
			GetComponent<GUIText>().fontSize = Screen.height / 7;
		}
		//change the size of guitext with tag "Paper"
		//this is title text
		if (GetComponent<GUIText>().tag == "Paper") {
			GetComponent<GUIText>().fontSize = Screen.height / 8;
		}
		//change the size of guitext with tag "HowToPlay"
		//Tap to play text size
		if (GetComponent<GUIText>().tag == "HowToPlay") {
			GetComponent<GUIText>().fontSize = Screen.height / 20;		
		}
		//change the size of guitext with tag "Score"
		//Left and Right texts size
		if (GetComponent<GUIText>().tag == "Score") {
			GetComponent<GUIText>().fontSize = Screen.height / 11;		
		}
	}
}

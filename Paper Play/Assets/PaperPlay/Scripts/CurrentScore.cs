using UnityEngine;
using System.Collections;

//the script will show your current score in GameOver page
public class CurrentScore : MonoBehaviour {
	
	public static float sceneTimer; //static float variable (Originally in script #Score)
	
	void Update () {

		//transform float sceneTimer variable to int and show using guiText
		GetComponent<GUIText>().text = "" + (int)Score.sceneTimer;
		GetComponent<GUIText>().fontSize = Screen.height / 11;
	}
	
}

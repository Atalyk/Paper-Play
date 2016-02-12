using UnityEngine;
using System.Collections;

//the script will show the best score in GameOver page
public class HighScore : MonoBehaviour {

	public static int highScore; // static integer variable (originally in script #Score)

	void Update () {

		//guiText will show the best score
		GetComponent<GUIText>().text = "" + Score.highScore;
		GetComponent<GUIText>().fontSize = Screen.height / 11;
	}
	
}

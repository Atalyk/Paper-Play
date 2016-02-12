using UnityEngine;
using System.Collections;

//the script indicate score and highscore
public class Score : MonoBehaviour {

	public static int highScore = 0; //static variable the highes score
	public static float sceneTimer; //sceneTimer to calculate a score
	public static bool running; 
	public static int start; //static boolean variable indicates if the plane is destroyed or not

	void Start() {
		sceneTimer = 0;
		//PlayerPrefs will store the highScore
		highScore = PlayerPrefs.GetInt("highScore", 0);
	}
	
	void OnDestroy() {
		//Sets the value of the preference identified by highScore
		PlayerPrefs.SetInt("highScore", highScore);
	}

	void Update () {


		//calculate the score by incrementing it each second
		if (PlaneMovement.running) {
			sceneTimer += Time.deltaTime;
		}
		//find highScore
		if ((int)sceneTimer > highScore) {
			highScore = (int)sceneTimer;
		}

		if (PlaneMovement.running) {
						GetComponent<GUIText>().fontSize = Screen.height / 13;
						GetComponent<GUIText>().text = "" + (int)sceneTimer;
				}
		if (!PlaneMovement.running) {
			GetComponent<GUIText>().fontSize = Screen.height / 13;
			GetComponent<GUIText>().text = "";
		}
	}
}

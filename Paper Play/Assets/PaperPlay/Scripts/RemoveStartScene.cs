using UnityEngine;
using System.Collections;

//Remove Start Page
public class RemoveStartScene : MonoBehaviour {

	public static bool running; //static boolean variable indicates if the plane is destroyed or not
	public static int start; //static integer indicates if Start/GameOver page is active
	
	void Update () {

		//hide/show "AVOID MOUNTAINS" text
		if (!PlaneMovement.running) {
			this.transform.GetChild (0).gameObject.SetActive (false);
		}
		if (PlaneMovement.running) {
			this.transform.GetChild (0).gameObject.SetActive (true);
		}
		//if start is equal 0 or running is false then Start page is active
		if ((StartPage.start == 0)|| !PlaneMovement.running) {
			this.transform.GetChild (1).gameObject.SetActive (true);
		}
		//if start is not equal 0 or running is true then Start page is not active
		if ((StartPage.start != 0)|| PlaneMovement.running) {
			this.transform.GetChild (1).gameObject.SetActive (false);
		}
	
	}
}

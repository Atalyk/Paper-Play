using UnityEngine;
using System.Collections;

public class PlaneMovement : MonoBehaviour {

	public GUISkin skin;  //GUI skin for button styles
	public static bool running; //static bool variable which indicates if the plane is destroyed or not


	public void OnGUI () 
	{	
		GUI.skin = skin;
	
						if (PlaneMovement.running) {
						//Button on the whole left side of the screen to move the plane to left
						if (GUI.RepeatButton (new Rect (Screen.width / 2, 0, Screen.width / 2, Screen.height), "", skin.GetStyle ("Right"))) {
								Vector3 position = this.transform.position;
								position.x = position.x + 0.2f;
								this.transform.position = position;
			
			
						}

						//Button on the whole right side of the screen to move the plane to right
						if (GUI.RepeatButton (new Rect (0, 0, Screen.width / 2, Screen.height), "", skin.GetStyle ("Left"))) {	     
								Vector3 position = this.transform.position;
								position.x = position.x - 0.2f;
								this.transform.position = position;
						}
				
				}
	}
}

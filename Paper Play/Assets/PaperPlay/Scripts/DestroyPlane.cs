using UnityEngine;
using System.Collections;

public class DestroyPlane : MonoBehaviour {
	
	public static bool running; //static boolean indicates if the plane is destroyed or not
	public static int start; //indicates if start page is active or not
	
	void OnTriggerEnter2D(Collider2D collider){
		
		//if the plane will collide with GameObject "Mountains"
		if (collider.tag == "Mountains") {
			//change a scale of the plane
			this.transform.localScale = new Vector3(0.1f, 0.1f, 0f);
			//Increment static integer
			StartPage.start++; 
			//the plane is destroyed
			PlaneMovement.running = false;
		}
	}
}

using UnityEngine;
using System.Collections;

//destroy unrequired objects (mountains and trees)
public class DestroyObjects : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){

		//if objects will collide with DestroyObjects 
		if (collider.tag == "DestroyMountains") {
			//destroy them
			Destroy(this.gameObject); 
		}
	}
}

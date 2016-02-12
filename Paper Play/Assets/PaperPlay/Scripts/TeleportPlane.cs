using UnityEngine;
using System.Collections;

//the script to teleport the plane from one side to another
public class TeleportPlane : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D collider){
		//if the plane is collided with RightWall then teleport it to the left
		if (collider.tag == "RightWall") {
			Vector3 position = this.transform.position;
			position.x = -3.5f;
			this.transform.position = position;
		}
		//if the plane is collided with LeftWall then teleport it to the right
		if (collider.tag == "LeftWall") {
			Vector3 position = this.transform.position;
			position.x = 3.5f;
			this.transform.position = position;
		}
	}
}

using UnityEngine;
using System.Collections;

public class ObjectMovement : MonoBehaviour {
	
	public static bool running;
	public float speed = 1f;
	
	void Update () {
		
		//if running is true (the plane is not destroyed) then objects will move downwards
		if (PlaneMovement.running) {
			speed = speed + 0.01f;
			transform.Translate (Vector3.down * Time.deltaTime*speed, Space.World);
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class NewObjects: MonoBehaviour {

	public Transform Mountain;//the mountain 
	public Transform MountainSecond;//another mountain (with a litte bit different style/size)
	public Transform Tree;//trees in the game
	public int RandomObject;//integer to randomly generate objects
	private float timer; //timer for frequency of the instantiation
	public float InstantiateY;//position Y
	public float InstantiateX;//position X
	public float LastInstantiateX;//avoid repeating variables
	public static bool running = false;//static variable indicates if the plane is destroyed or not

	void Update () {
				
				//if the plane is not destroyed
				if (PlaneMovement.running) {

								//set InstantiateX to LastInstantiateX
								LastInstantiateX = InstantiateX;
								//generate random position Y
								InstantiateY = InstantiateY + 0.03f;
								//generate random integer for random objects
								RandomObject = Random.Range (0, 3);
								//generate random position X
								InstantiateX = Random.Range (-3f, 3f);
								//frequency of the generation
								timer -= Time.deltaTime;
								//if repeated then take another value
								if (LastInstantiateX < 0 && InstantiateX < 0) {
									InstantiateX = Random.Range (-3f, 3f);
								}
								if (timer < 0) {

									
										if (RandomObject == 0) {
												Instantiate (Tree, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (RandomObject == 1) {
												if (InstantiateX < 0)
														Instantiate (Mountain, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
												else 
														Instantiate (MountainSecond, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (RandomObject == 2) {
												if (InstantiateX < 0)
														Instantiate (Mountain, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
												else 
														Instantiate (MountainSecond, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										timer = Random.Range (0.4f, 0.5f);
								}
						
				}
		}
}

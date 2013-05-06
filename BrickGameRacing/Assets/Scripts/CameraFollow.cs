using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	public PlayerCarObject Car;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Stop Camera when car collides
		if(!Car.collided && !Car.IsPaused)
		{
			//forward movement
			transform.Translate(Vector3.up * Car.movementSpeed);
		}
	}
}

using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	public PlayerCarObject car;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Stop Camera when car collides
		if(!car.collided)
		{
			//forward movement
			transform.Translate(Vector3.up * car.movementSpeed);
		}
	
	}
}

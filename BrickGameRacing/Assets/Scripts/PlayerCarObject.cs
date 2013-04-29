using UnityEngine;
using System.Collections;

public class PlayerCarObject : MonoBehaviour {
	
	private float maxX = 3.5f;
	private float minX = -3.5f;
	
	public float movementSpeed = 0.5f;
	public float steeringSpeed = 30.0f;
	public bool isPlayerObject, collided;
	
	// Use this for initialization
	void Start () {
		collided = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPlayerObject)
		{
			if(!collided)
			{
				//forward movement
				transform.Translate(Vector3.up * movementSpeed);
				//steering movement
				transform.Translate (Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * steeringSpeed);
			}
			else
			{
				//Show Particle crash
				Debug.Log("Crash");
				renderer.enabled = false;
			}
			
			//Steady position in x-axis
			Vector3 pos = transform.position;
			pos.z = pos.z;
			pos.x = Mathf.Clamp(pos.x, minX, maxX);
			pos.y = Mathf.Clamp(pos.y, 0.0f, 0.0f);
			transform.position = pos;
		
		}
	}
	
	void OnTriggerEnter (Collider col)
	{
		if(col.tag == "Obstacle")
			collided = true;
			Application.LoadLevel(2);
	}
	
}

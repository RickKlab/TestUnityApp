using UnityEngine;
using System.Collections;

public class GameUIManager : MonoBehaviour {
	
	public UILabel DistanceLabel;
	private float DistanceTraveled;
	public PlayerCarObject Car;
	
	private float AdditionalDistance;
	
	// Use this for initialization
	void Start () {
		
		DistanceTraveled = 0f;
		AdditionalDistance = 0.01f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (!Car.collided && !Car.IsPaused)
		{	
			DistanceTraveled += AdditionalDistance;
			
			//Speedometer increment
			if(Car.transform.position.z > Car.DistanceMark)
			{
				AdditionalDistance += 0.03f;
			}
			
			DistanceLabel.text = DistanceTraveled.ToString("F2");
		}
		
	}
}

using UnityEngine;
using System.Collections;

public class PlatformManager : MonoBehaviour {
	
	public RoadObject[] planes;
	public PlayerCarObject car;
	
	private float currentPosition;
	public int index, distanceChecker;
	public bool IsPaused;
	
	// Use this for initialization
	void Start () {
		currentPosition = car.transform.position.z;
		IsPaused = false;
		
		index = 0;
		distanceChecker = 30;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if(!IsPaused)
		{
			car.IsPaused = false;
			currentPosition = car.transform.position.z;
			if (currentPosition > distanceChecker)
			{
				Vector3 pos = new Vector3(planes[index].transform.position.x, planes[index].transform.position.y, planes[index].transform.position.z + 120);
				planes[index].transform.position= pos;
			
				RoadObject road = (RoadObject)planes[index].GetComponent("RoadObject");
				road.RandomObstacle();
			
				if(index < 3)
					index++;
				else
					index = 0;
			
				distanceChecker += 30;	
			}
		}
		else{
			car.IsPaused = true;
		}
	}
}

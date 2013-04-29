using UnityEngine;
using System.Collections;

public class RoadObject : MonoBehaviour {
	
	public ObstacleObject obstacle;
	private float maxX = 3.5f;
	private float minX = -3.5f;
	int subtractor = 15;
	
	// Use this for initialization
	void Start () 
	{	
		RandomObstacle();
		
		for(int x = 0; x < 3; x++)
		{
			//ObstacleObject newObstacle = (ObstacleObject)Instantiate(Resources.Load("Obstacle"));
			//newObstacle.RandomObstaclePosition();
		}
	}
	
	public void RandomObstacle()
	{
		Vector3 pos = transform.position;
		obstacle.RandomObstaclePosition(minX, maxX, pos.z - subtractor, pos.z);
		
		if(subtractor < 30)
			subtractor = 30;
	}
	
}

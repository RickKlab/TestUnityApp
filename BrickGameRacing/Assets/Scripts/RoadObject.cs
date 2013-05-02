using UnityEngine;
using System.Collections;

public class RoadObject : MonoBehaviour {
	
	public ObstacleObject obstacle;
	private float maxX = 3.5f;
	private float minX = -3.5f;
	
	// Use this for initialization
	void Start () 
	{	
		//RandomObstacle();
	}
	
	public void RandomObstacle()
	{
		Vector3 pos = transform.position;
		obstacle.RandomObstaclePosition(minX, maxX, pos.z - 15, pos.z + 15);
	}
	
}

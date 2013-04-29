using UnityEngine;
using System.Collections;

public class ObstacleObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void RandomObstaclePosition( float minX, float maxX , float minZ, float maxZ)
	{
			Vector3 pos = transform.position;
			pos.z = Random.Range(minZ, maxZ);
			pos.x = Random.Range(minX, maxX);
			pos.y = pos.y;
			transform.position = pos;
	}

}

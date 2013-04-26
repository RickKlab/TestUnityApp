using UnityEngine;
using System.Collections;

public class MenuObject : MonoBehaviour {
	
	public bool isQuit = false;
	
	void OnMouseEnter()
	{
		renderer.material.color = Color.red;
		Debug.Log("Mouse Enter");
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
		Debug.Log("onMouseExit");
	}
	
	void OnMouseDown()
	{
		Application.LoadLevel(1);
	}
}

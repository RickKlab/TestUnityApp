using UnityEngine;
using System.Collections;

public class UIButtonObject : MonoBehaviour {
	
	
	public bool toMainMenu, toGameScene, toGameOver;
	
	// Use this for initialization
	void Start () {
	
	}
	
	void OnClick()
	{
		if(toMainMenu)
		{
			MoveToMainMenu();
		}
		else if(toGameOver)
		{
			MoveToGameOverScene();
		}
		else if (toGameScene)
		{
			MoveToGame();
		}
		
	}
	
	void MoveToGame()
	{
		Application.LoadLevel(1);
	}
	
	void MoveToGameOverScene()	
	{
		Application.LoadLevel(2);
	}
	
	void MoveToMainMenu()
	{
		Application.LoadLevel(0);
	}
}

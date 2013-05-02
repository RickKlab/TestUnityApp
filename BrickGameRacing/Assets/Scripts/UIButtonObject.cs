using UnityEngine;
using System.Collections;

public class UIButtonObject : MonoBehaviour {
	
	public bool toMainMenu, toGameScene, toGameOver;
	public UIButton button;
	
	// Use this for initialization
	void Start () {
		Vector3 pos = transform.position;
		pos.x += 3;
		
		button.disabledColor = Color.white;
		button.isEnabled = false;
		
		//Test animation
		iTween.MoveTo(this.gameObject, iTween.Hash("x", pos.x, "time", 1.5f, "easeType", iTween.EaseType.easeOutBounce));
		
		StartCoroutine(EnableButton(1.5f));
	}
	
		//Delay before changed Scene
	IEnumerator EnableButton(float delay)
	{
    	yield return new WaitForSeconds(delay);
		button.isEnabled = true;
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

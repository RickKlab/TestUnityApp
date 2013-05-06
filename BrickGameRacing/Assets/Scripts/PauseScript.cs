using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	
	public UIButton PauseButton;
	public PlatformManager mananger;
	private bool DidPause;
	// Use this for initialization
	void Start () 
	{
		DidPause = false;
	}
	
	void OnClick()
	{
		if(DidPause)
		{
			DidPause = false;
			mananger.IsPaused = false;
		}
		else
		{
			DidPause = true;
			mananger.IsPaused = true;
		}
		
	}
}

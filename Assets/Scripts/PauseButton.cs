using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
	private bool gameIsPause = false;
	public void PauseBut()
	{
		gameIsPause = !gameIsPause;
		if (gameIsPause)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}

	}
}

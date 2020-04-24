using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayButton : MonoBehaviour
{
	public GameObject player;
	public WaveController waveController;
	public GameObject changeLoadButton;
	public void ReloadScene()
	{
		gameObject.SetActive(false);
		changeLoadButton.SetActive(false);
		player.SetActive(true);
		waveController.ResetGame();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XXTest : MonoBehaviour
{
	public GameObject changeLoadoutButton;
	public GameObject inGameUI;
	private void Awake()
	{
		Time.timeScale = 0;
	}

	public void StartGame()
	{
		changeLoadoutButton.SetActive(false);
		gameObject.SetActive(false);
		inGameUI.SetActive(true);
		Time.timeScale = 1;
	}
}

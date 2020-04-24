using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XXTest : MonoBehaviour
{
	public GameObject changeLoadoutButton;
	private void Awake()
	{
		Time.timeScale = 0;
	}

	public void StartGame()
	{
		changeLoadoutButton.SetActive(false);
		gameObject.SetActive(false);
		Time.timeScale = 1;
	}
}

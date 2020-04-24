using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentWaveUI : MonoBehaviour
{
	public Text text;
	public WaveController waveController;
	// Update is called once per frame
	void Update()
	{
		text.text = "wave " + waveController.CurrentWave;
	}
}

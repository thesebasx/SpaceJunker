using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesLeftUI : MonoBehaviour
{
	public WaveController waveController;
	public Text text;
	// Update is called once per frame
	void Update()
    {
		text.text = "Enemies Left: " + waveController.EnemiesLeft;
    }
}

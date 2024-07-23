using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FiniteLevelController : MonoBehaviour
{
	[System.Serializable]
	public class WaveList
	{
		public Wave wave;
		public float timeForNextWave;
	}

	public WaveList[] waves;

	private float timer = 0;
	private int currentWave;

	private void Awake()
	{
		Wave.OnEndWave += EndWave;
	}
	private void Start()
	{
		currentWave = 0;
		Instantiate(waves[currentWave].wave, transform.position, Quaternion.identity);
	}

	private void EndWave(Wave wave)
	{
		timer = waves[currentWave].timeForNextWave;
		currentWave += 1;
		if (currentWave < waves.Length)
		{
			StartCoroutine(WaitForTime(timer));
		}
		
	}

	IEnumerator WaitForTime(float time)
	{
		yield return new WaitForSeconds(time);
		Instantiate(waves[currentWave].wave, transform.position, Quaternion.identity);
	}

	

	
}

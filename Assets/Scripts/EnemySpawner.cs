using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject enemyPrefab;

	[SerializeField]
	private float spawnRate = 1.0f;
	private float timer;

	WaveController waveController;
	

	private void Start()
	{
		waveController = GetComponent<WaveController>();
	}
	private void Update()
	{
		

		timer += Time.deltaTime;
		if (timer > spawnRate)
		{
			if (waveController.EnemiesLeft > 0)
			{
				SpawnEnemy();
				timer = 0.0f;
			}	
		}


	}

	void SpawnEnemy()
	{
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0.2f, 0.0f));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0.8f, 1.0f));

		Vector2 spawnPoint = new Vector3(Random.Range(min.x, max.x), max.y);
		GameObject enemy = (GameObject)Instantiate(enemyPrefab);
		enemy.transform.position = spawnPoint;
	}

	public void IncreaseSpawnRate()
	{
		if (spawnRate > 1f)
		{
			spawnRate--;
		}
		else if (spawnRate > 0.5f)
		{
			spawnRate -= 0.1f;
		}
	}

	public void ResetSpawnRate()
	{
		spawnRate = 2.0f;
	}


}

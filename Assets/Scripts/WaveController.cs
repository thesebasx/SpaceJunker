using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour
{
	[SerializeField]
	private int enemiesPerWave = 10;
	private int currentWave;
	private int enemiesLeft;
	private float restTimer;
	private float restTimePerWave = 5.0f;

	EnemySpawner enemySpawner;

	public int EnemiesLeft => enemiesLeft;
	public int CurrentWave => currentWave;
	
    // Start is called before the first frame update
    void Awake()
    {
		enemySpawner = GetComponent<EnemySpawner>();
		enemiesLeft = enemiesPerWave;
		restTimer = restTimePerWave;
		currentWave = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesLeft <= 0)
		{
			restTimer -= Time.deltaTime;
			if (restTimer <= 0f)
			{
				currentWave++;
				enemiesPerWave += 5;
				enemiesLeft = enemiesPerWave;
				enemySpawner.IncreaseSpawnRate();
				restTimer = restTimePerWave;
			}
			
		}
    }

	public void DecreaseEnemiesLeft()
	{
		enemiesLeft -= 1;
		enemiesLeft = Mathf.Clamp(enemiesLeft, 0, enemiesPerWave);
	}

	public void ResetGame()
	{
		enemiesPerWave = enemiesPerWave - (currentWave - 1) * 5;
		currentWave = 1;
		enemiesLeft = enemiesPerWave;
		enemySpawner.ResetSpawnRate();
		gameObject.SetActive(true);
	}
}

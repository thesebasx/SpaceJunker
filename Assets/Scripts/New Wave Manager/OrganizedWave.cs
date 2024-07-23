using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OrganizedWave : Wave
{
	
	//public GameObject enemy;
	//[Space]
	//public int numberOfEnemies;
	[Space]
	[Range(0, 1)]
	public float startPosition;
	[Range(-1, 1)]
	public int spaceBetween;
	[Space]
	public float timeBetween;
	[Space]
	public float offset;
	
	private Vector2 spawnPosition;
	private float spawnTimer;
	private Camera mainCamera;
	private float totalEnemies;

	private void Start()
	{
		totalEnemies = numberOfEnemies;
		mainCamera = Camera.main;
		spawnTimer = timeBetween;
	}
	override public void Update()
	{
		base.Update();

		if (numberOfEnemies > 0)
		{
			spawnTimer += Time.deltaTime;
			if(spawnTimer >= timeBetween)
			{
				spawnPosition = mainCamera.ViewportToWorldPoint(new Vector2(startPosition, 1 + offset));
				SpawnEnemy();
				spawnTimer = 0;
				numberOfEnemies--;
			}
			 
		}

		
		
	}

	public void SpawnEnemy()
	{
		GameObject anEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity);
		anEnemy.transform.Rotate(new Vector3(0, 0, 180));
	}

	

}

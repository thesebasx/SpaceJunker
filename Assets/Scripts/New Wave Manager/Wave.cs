using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Wave : MonoBehaviour
{
	public static event Action<Wave> OnEndWave = delegate { };

	public GameObject enemy;
	[Space]
	public int numberOfEnemies;

	public virtual void Update()
	{
		if (numberOfEnemies <= 0)
		{
			OnEndWave(this);
			gameObject.SetActive(false);
		}
	}

}


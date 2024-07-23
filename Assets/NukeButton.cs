using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeButton : MonoBehaviour
{
	[SerializeField]
	private float NukeCooldown = 120;
	private float timer;

	private void Update()
	{
		if (timer > 0)
		{
			timer -= Time.deltaTime;
		}
	}

	public void Nuke()
	{
		if (timer > 0)
		{
			return;
		}
		EnemyHealth[] enemies = FindObjectsOfType<EnemyHealth>();

		foreach(EnemyHealth enemy in enemies)
		{
			enemy.TakeDamage(10);
		}

		timer = NukeCooldown;

		



	}
}

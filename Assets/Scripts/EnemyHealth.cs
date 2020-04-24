using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, ITakeDamage
{
	PlayerEquipment playerEquipment;

	[SerializeField]
	private float health;
	private bool isAlive = true;

	// Start is called before the first frame update
	void Start()
    {
		playerEquipment = GetComponent<PlayerEquipment>();
		health = playerEquipment.health;
    }
	public void TakeDamage(float damage)
	{
		health = health - damage;
		if (health <= 0 && isAlive)
		{
			isAlive = false;
			Die();
		}
	}

	private void Die()
	{
		WaveController waveController = FindObjectOfType<WaveController>();
		if (waveController != null)
			waveController.DecreaseEnemiesLeft();
		Destroy(gameObject);
	}
}

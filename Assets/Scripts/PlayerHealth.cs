using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, ITakeDamage
{
	//public GameObject enemySpawner;
	//public GameObject replayButton;
	//public GameObject changeLoadButton;
	PlayerEquipment playerEquipment;
	[SerializeField]
	private float health;

	public float Health => health;
	// Start is called before the first frame update
	void Start()
    {
		playerEquipment = GetComponent<PlayerEquipment>();
		health = playerEquipment.health;
    }
	public void TakeDamage(float damage)
	{
		health -= damage;
		health = Mathf.Clamp(health, 0, playerEquipment.health);
		if (health <= 0)
		{
			Die();
		}
	}

	public void UpdatePlayerHealth(float newHealth)
	{
		health = newHealth;
	}

	private void Die()
	{
		//enemySpawner.SetActive(false);
		gameObject.SetActive(false);
		//replayButton.SetActive(true);
		//changeLoadButton.SetActive(true);
		health = playerEquipment.health;
	}


}

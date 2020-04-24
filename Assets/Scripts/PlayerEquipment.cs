using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
	public ShipSO ship;
	public BulletSO bullet;

	SpriteRenderer spriteRenderer;

	[HideInInspector]
	public float health, shield, bulletsPerSecond, bulletDamage, bulletSpeed;

	// Start is called before the first frame update
	void Awake()
    {
		spriteRenderer = GetComponent<SpriteRenderer>();
		UpdatePlayerShip();
		UpdatePlayerBullet();
	}

	public void UpdatePlayerShip()
	{
		spriteRenderer.sprite = ship.shipSprite;
		health = ship.health;
		PlayerHealth playerHealth = gameObject.GetComponent<PlayerHealth>();
		if (playerHealth != null)
			playerHealth.UpdatePlayerHealth(health);
		shield = ship.shield;
		bulletsPerSecond = ship.bulletsPerSecond;
		
	}

	public void UpdatePlayerBullet()
	{
		bulletDamage = bullet.bulletDamage;
		bulletSpeed = bullet.bulletSpeed;

	}
}

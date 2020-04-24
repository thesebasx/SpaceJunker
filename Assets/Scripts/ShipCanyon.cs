using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCanyon : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform firePoint;

	PlayerEquipment playerEquipment;

	private float canyonTimer;
	private float canyonRefresh;
	private float bulletsPerSecond;

	void Start()
	{
		playerEquipment = GetComponent<PlayerEquipment>();
		bulletsPerSecond = playerEquipment.bulletsPerSecond;
		canyonRefresh = 1.0f / bulletsPerSecond;
	}
	
	void Update()
    {
		canyonTimer += Time.deltaTime;

		if (canyonTimer > canyonRefresh)
		{
			PlayerShoot();
			canyonTimer = 0.0f;
		}
    }

	private void PlayerShoot()
	{
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

		SpriteRenderer bulletSR = bullet.GetComponent<SpriteRenderer>();
		bulletSR.sprite = playerEquipment.bullet.bulletSprite;

		Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
		bulletRB.AddForce(Vector2.up * playerEquipment.bulletSpeed, ForceMode2D.Impulse);

		BulletControl bulletControl = bullet.GetComponent<BulletControl>();
		var damage = playerEquipment.bulletDamage;
		bulletControl.bulletDamage = damage;
	}

	public void SetCanyonRefresh(float changeRate)
	{
		canyonRefresh /= changeRate;
	}

	
}

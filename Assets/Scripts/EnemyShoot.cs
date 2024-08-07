﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform firePoint;

	private string playerName = "Player";
	PlayerEquipment playerEquipment;
    // Start is called before the first frame update
    void Start()
    {
		playerEquipment = GetComponent<PlayerEquipment>();
		float probOfShooting = Random.Range(1, 100);
		if (probOfShooting <= 50)
			Invoke("Shoot", 0.5f);

	}

	private void Shoot()
	{
		GameObject player = GameObject.Find(playerName);

		Vector2 direction =  player.transform.position - gameObject.transform.position;

		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

		SpriteRenderer bulletSR = bullet.GetComponent<SpriteRenderer>();
		bulletSR.sprite = playerEquipment.bullet.bulletSprite;

		Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
		bulletRB.AddForce(direction.normalized * playerEquipment.bulletSpeed, ForceMode2D.Impulse);

		BulletControl bulletControl = bullet.GetComponent<BulletControl>();
		var damage = playerEquipment.bulletDamage;
		bulletControl.bulletDamage = damage;
	}
}

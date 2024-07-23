using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform firePoint;

	PlayerEquipment playerEquipment;
	Rigidbody2D rb;
	Vector2 mousePos;

	//private bool playerIsShooting;


	// Start is called before the first frame update
	void Start()
    {
		playerEquipment = GetComponent<PlayerEquipment>();
		rb = GetComponent<Rigidbody2D>();
		InvokeRepeating("PlayerShoot", 0.0f, 1.0f / playerEquipment.bulletsPerSecond);
    }

	private void FixedUpdate()
	{
		if (mousePos.magnitude > 0f)
		{
			Vector3 screenPos = new Vector3(mousePos.x, mousePos.y, 10f);
			Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
			rb.MovePosition(worldPos);
		}

		
		
	}

	public void PlayerShoot()
	{
		
		//if (playerIsShooting == false)
		//	return;

		
			
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

		SpriteRenderer bulletSR = bullet.GetComponent<SpriteRenderer>();
		bulletSR.sprite = playerEquipment.bullet.bulletSprite;

		Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
		bulletRB.AddForce(Vector2.up * playerEquipment.bulletSpeed, ForceMode2D.Impulse);

		BulletControl bulletControl = bullet.GetComponent<BulletControl>();
		var damage = playerEquipment.bulletDamage;
		bulletControl.bulletDamage = damage;
	}
}

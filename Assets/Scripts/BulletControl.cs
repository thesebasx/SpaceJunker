using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
	public float bulletDamage;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		ITakeDamage takeDamage = collision.gameObject.GetComponent<ITakeDamage>();
		if (takeDamage != null)
		{
			takeDamage.TakeDamage(bulletDamage);
			Destroy(gameObject);
		}

		
	}

	private void Update()
	{
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

		if (transform.position.y > max.y || transform.position.y < min.y)
		{
			Destroy(gameObject);
		}
	}

}

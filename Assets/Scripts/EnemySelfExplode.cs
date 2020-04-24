using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySelfExplode : MonoBehaviour
{
	[SerializeField]
	private float explosionDamage;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		ITakeDamage takeDamage = collision.gameObject.GetComponent<ITakeDamage>();
		if (takeDamage != null)
		{
			takeDamage.TakeDamage(explosionDamage);
			Destroy(gameObject);
		}
		
	}
}

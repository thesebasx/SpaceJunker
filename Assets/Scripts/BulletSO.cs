using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "Items/Bullets")]
public class BulletSO : ScriptableObject
{
	public string bulletName;
	public string bulletDescription;

	public Sprite bulletSprite;

	public float bulletDamage;
	public float bulletSpeed;
}

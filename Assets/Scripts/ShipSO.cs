using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ship", menuName = "Ship")]
public class ShipSO : ScriptableObject
{
	public string shipName;
	public string shipDescription;

	public Sprite shipSprite;

	public float health;
	public float shield;
	public float bulletsPerSecond;

}

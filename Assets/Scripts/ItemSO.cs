using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Item")]
public class ItemSO : ScriptableObject
{
	public string itemName;
	public string itemDescription;

	public Sprite itemSprite;

	public bool usable;
	public bool unique;

	public int amountHeld;

}

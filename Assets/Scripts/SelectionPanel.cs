using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPanel : MonoBehaviour
{
	public GameObject shipSelectPanel;
	public GameObject bulletSelectPanel;
	public GameObject player;
	public ShipSO[] shipOptions;
	public BulletSO[] bulletOptions;
    // Start is called before the first frame update
    
	public void ShipSelection(int i)
	{
		PlayerEquipment playerEquip = player.GetComponent<PlayerEquipment>();
		playerEquip.ship = shipOptions[i - 1];
		playerEquip.UpdatePlayerShip();
		bulletSelectPanel.SetActive(true);
		shipSelectPanel.SetActive(false);
	}

	public void BulletSelection(int i)
	{
		PlayerEquipment playerEquip = player.GetComponent<PlayerEquipment>();
		playerEquip.bullet = bulletOptions[i - 1];
		playerEquip.UpdatePlayerBullet();
		bulletSelectPanel.SetActive(false);
		shipSelectPanel.SetActive(true);
		gameObject.SetActive(false);
		//player.SetActive(true);
	}
}

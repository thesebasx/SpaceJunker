using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectShipButton : MonoBehaviour
{
	public ShipSO ship;

	public Image sprite;
	public Text nameText;
	public Text descriptionText;
    // Start is called before the first frame update
    void Start()
    {
		sprite.sprite = ship.shipSprite;
		nameText.text = ship.shipName;
		descriptionText.text = ship.shipDescription;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBulletButton : MonoBehaviour
{
	public BulletSO bullet;

	public Image sprite;
	public Text nameText;
	public Text descriptionText;
	// Start is called before the first frame update
	void Start()
	{
		sprite.sprite = bullet.bulletSprite;
		nameText.text = bullet.bulletName;
		descriptionText.text = bullet.bulletDescription;
	}
}

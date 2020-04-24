using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthText : MonoBehaviour
{
	public GameObject player;
	public Text text;
	PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
		playerHealth = player.GetComponent<PlayerHealth>();
		//playerHealth = FindObjectOfType<PlayerHealth>();
		
    }

	private void Update()
	{
		text.text = "Health: " + playerHealth.Health.ToString();
	}


}

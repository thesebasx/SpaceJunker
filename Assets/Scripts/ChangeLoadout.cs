using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLoadout : MonoBehaviour
{
	public GameObject selecShipCanvas;
    
	public void OpenChangeLoadoutMenu()
	{
		selecShipCanvas.SetActive(true);
	}
}

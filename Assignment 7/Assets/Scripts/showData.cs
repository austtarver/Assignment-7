using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
	public Text PanelNameText;
	
	public Text PanelSpeedText;
	
	

	private void Awake()
	{
		PanelNameText.text = keepData.PlayerName;

		PanelSpeedText.text = "Speed: " + keepData.PlayerSpeedMultiplier.ToString();


	}
	private void Update()
	{
		
	}
}


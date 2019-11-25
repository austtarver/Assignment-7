using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// added

//attached to data manager object in all scenes

public class keepData : MonoBehaviour
{
	public static string PlayerName = "Anonymous";
	
	

	public InputField PlayerNameInput;
	public Slider PlayerSpeedSlider;
	public static float PlayerSpeedMultiplier = 1.0f;
	
	
	// don't forget to fill these fields in the inspector for data manager

	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
	}
	private void Update()
	{
		//Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
	}
	public void UpdateName()
	{
		PlayerName = PlayerNameInput.text;
	}
	
	public void ChangeSpeed()
	{
		PlayerSpeedMultiplier = PlayerSpeedSlider.value;
	}

	



}

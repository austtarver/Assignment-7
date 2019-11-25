using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
	private AudioSource sound;
	public AudioClip keystroke;

	public Text text;
	public float fallSpeed = 1f;

	public static int Score = 0;
	public static int MissedScore;
	public static int highScore = 0;
	

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	private void Awake()
	{
		sound = GetComponent<AudioSource>();
	
		
	}

	public void RemoveWord()
	{
		Score++;
		if(Score > highScore)
		{
			highScore = Score;
			
		}
		Destroy(gameObject);

		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "wall")
		{
			MissedScore++;
		}
	}




	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime* keepData.PlayerSpeedMultiplier, 0f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
	public void StartPlay()
	{
		SceneManager.LoadScene("Main");
		WordDisplay.Score = 0;
		WordDisplay.MissedScore = 0;
	}

	public void StopPlaying()
	{
		SceneManager.LoadScene("Exit");
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene("Intro");
	}

	public void ExitGame()
	{
		// exit the game for real play
		//Application.Quit();
		//does not work in Unity since it would  lose all settings. so:
		UnityEditor.EditorApplication.isPlaying = false;
	}
}

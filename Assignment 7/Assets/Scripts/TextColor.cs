using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour
{
	public Dropdown WordColor;
	public Text text;

	// Update is called once per frame

	public void SetWord(string word)
	{
		text.text = word;
	}
	

	public void PickColor()
	{
		switch(WordColor.value)
		{
			
			case 1:
				text.color = Color.green;
				
				break;
			case 2:
				text.color = Color.yellow;
				
				break;
			case 3:
				text.color = Color.white;
				
				break;

		}
	}
	

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSpeed : MonoBehaviour
{
	public Slider PlayerSpeedSlider;
	public float textspeed;

    // Update is called once per frame
    public void SetSpeed()
    {
		textspeed = PlayerSpeedSlider.value;
		DontDestroyOnLoad(this.gameObject);
	}
}

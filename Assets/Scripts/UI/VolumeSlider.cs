using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
	[SerializeField] private Slider slider = null;

	private void Start()
	{
		Debug.Log("started");
		slider.value = Global.music.volume;
		slider.maxValue = Global.maxMusicVolume;
	}

	public void AdjustVolume(float volume)
	{
		Global.music.volume = slider.value;
	}
}

/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Volume slider script.
 */

using UnityEngine;
using UnityEngine.UI;


/**
 * NAME    : VolumeSlider
 * PURPOSE :
 *	- Volume slider script.
 */
public class VolumeSlider : MonoBehaviour
{
	[SerializeField] private Slider slider = null;


	/**
	 * \brief	Establishes the max value for the volume.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		Debug.Log("started");
		slider.value = Global.music.volume;
		slider.maxValue = Global.maxMusicVolume;
	}


	/**
	 * \brief	Adjusts the volume based on the position of the slider.
	 * \param	void
	 * \return	void
	 */
	public void AdjustVolume()
	{
		Global.music.volume = slider.value;
	}
}

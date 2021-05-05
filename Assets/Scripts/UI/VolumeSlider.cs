/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/**
 * NAME    : VolumeSlider
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class VolumeSlider : MonoBehaviour
{
	[SerializeField] private Slider slider = null;


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	private void Start()
	{
		Debug.Log("started");
		slider.value = Global.music.volume;
		slider.maxValue = Global.maxMusicVolume;
	}


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param
	 * 
	 * \return	void
	 */
	public void AdjustVolume(float volume)
	{
		Global.music.volume = slider.value;
	}
}

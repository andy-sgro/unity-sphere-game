/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * NAME    : KeepMusic
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class KeepMusic : MonoBehaviour
{

	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	private void Awake()
    {
		DontDestroyOnLoad(gameObject);
		AudioSource audio = gameObject.GetComponent<AudioSource>();
		if (audio != null)
		{
			Global.music = audio;
			Global.maxMusicVolume = audio.volume;
		}
    }

}

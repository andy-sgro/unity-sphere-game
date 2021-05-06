/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Ensures that the music that gets loaded in the first scene persists through all scenes.
 */

using UnityEngine;


/**
 * NAME    : KeepMusic
 * PURPOSE :
 *	- Ensures that the music that gets loaded in the first scene persists through all scenes.
 *	- This class uses the Global class to keep values in memory.
 */
public class KeepMusic : MonoBehaviour
{

	/**
	 * \brief	Ensures that the music that gets loaded in the first scene persists through all scenes.
	 * \param	void
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

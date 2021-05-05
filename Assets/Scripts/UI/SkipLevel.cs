/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Goes to the next scene.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * NAME    : SkipLevel
 * PURPOSE :
 *	- Goes to the next scene.
 *	- This script is last in the 'script execustion order'.
 */
public class SkipLevel : MonoBehaviour
{
	/**
	 * \brief	Loads the next scene.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}

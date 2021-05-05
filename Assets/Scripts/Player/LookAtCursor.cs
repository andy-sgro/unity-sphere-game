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
 * NAME    : LookAtCursor
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class LookAtCursor : MonoBehaviour
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
	private void Update()
    {
		if (Time.timeScale != 0.0f)
		{
			transform.localRotation = Quaternion.Euler(0, Cursor.Angle, 0);
		}
    }
}

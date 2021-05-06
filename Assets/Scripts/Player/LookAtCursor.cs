/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Makes the GameObject face the mouse cursor.
 */

using UnityEngine;


/**
 * NAME    : LookAtCursor
 * PURPOSE :
 *	- Makes the GameObject face the mouse cursor.
 */
public class LookAtCursor : MonoBehaviour
{

	/**
	 * \brief	Makes the GameObject face the mouse cursor.
	 * \param	void
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

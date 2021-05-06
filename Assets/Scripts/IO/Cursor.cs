/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: An abstraction layer for accessing the mouse cursor's position.
 */

using UnityEngine;

/**
 * NAME    : Cursor
 * PURPOSE :
 *	- An abstraction layer for accessing the mouse cursor's position.
 */
public static class Cursor
{

	/**
	 * \brief	Returns the screen coordinates of the cursor.
	 * \return	"
	 */
	public static Vector2 Position
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}


	/**
	 * \brief	Returns the angle of the cursor from the center of the screen.
	 * \return	"
	 */
	public static float Angle
	{
		get
		{
			Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2);
			return TrigPhysics.GetAngle(screenCenter, Input.mousePosition);
		}
	}
}

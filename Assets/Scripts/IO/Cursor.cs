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
 * NAME    : Cursor
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public static class Cursor
{

	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param
	 * 
	 * \return
	 */
	public static float X
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		}
	}


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param
	 * 
	 * \return
	 */
	public static float Y
	{
		get
		{
			return Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		}
	}


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param
	 * 
	 * \return
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

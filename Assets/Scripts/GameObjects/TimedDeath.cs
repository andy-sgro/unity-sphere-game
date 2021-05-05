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
 * NAME    : TimedDeath
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class TimedDeath : MonoBehaviour
{
	[SerializeField] private float timeTillDie;




	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	void FixedUpdate()
    {
		timeTillDie -= Time.fixedDeltaTime;
		if (timeTillDie <= 0)
		{
			Destroy(gameObject);
		}
	}
}

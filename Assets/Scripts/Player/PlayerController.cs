/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereTraveller))]


/**
 * NAME    : PlayerController
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class PlayerController : MonoBehaviour
{
	private SphereTraveller st = null;


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
		st = GetComponent<SphereTraveller>();
	}


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	private void FixedUpdate()
	{
		// get keyboard input
		float xMove = Input.GetAxis("Horizontal") * st.speed;
		float yMove = Input.GetAxis("Vertical") * st.speed;

		st.Translate(xMove, yMove);
	}

}

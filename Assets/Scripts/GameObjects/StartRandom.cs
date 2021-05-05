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
 * NAME    : StartRandom
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class StartRandom : MonoBehaviour
{
	private SphereTraveller surfaceTraveller;



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
		surfaceTraveller = GetComponent<SphereTraveller>();


		float halfCir = (surfaceTraveller.Radius * Mathf.PI * Mathf.PI * 2) / Time.fixedDeltaTime;

		surfaceTraveller.Translate(Random.Range(-halfCir, halfCir), Random.Range(-halfCir, halfCir));
		surfaceTraveller.Rotate(Random.Range(-180, 180));
    }


}

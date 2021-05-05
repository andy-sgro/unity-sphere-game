/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Deletes the parent GameObject when it travels a specific distance.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * NAME    : MaxDist
 * PURPOSE :
 *	- Deletes the parent GameObject when it travels a specific distance.
 */
public class MaxDist : MonoBehaviour
{
	[SerializeField] private float maxDist;

	private float distTravelled = 0;
	private bool toDelete = false;
	private Vector3 lastPos;


	/**
	 * \brief	Sets the last position.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		lastPos = transform.position;
	}


	/**
	 * \brief	Measures the distance travelled, and deletes
	 *			the object if the specified distance has been travelled.
	 * 
	 * \param	void
	 * \return	void
	 */
	private void FixedUpdate()
    {
		if (!toDelete)
		{
			Vector3 currPos = transform.position;
			distTravelled += Vector3.Distance(currPos, lastPos);
			lastPos = currPos;

			if (distTravelled >= maxDist)
			{
				toDelete = true;
				GameObject gameObject = this.gameObject;
				Destroy(gameObject);
			}
		}
	}
}

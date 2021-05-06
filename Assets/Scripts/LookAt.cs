/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Makes a transform face towards another transform.
 */

using UnityEngine;


/**
 * NAME    : LookAt
 * PURPOSE :
 *	- Makes a transform face towards another transform.
 */
public class LookAt : MonoBehaviour
{
	[SerializeField] private Transform lookAt;


	/**
	 * \brief	Makes a transform face towards another transform.
	 * \param	void
	 * \return	void
	 */
	private void FixedUpdate()
    {
		transform.LookAt(lookAt.position);
	}
}

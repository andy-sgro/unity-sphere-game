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
 * NAME    : OrbitCamera
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class OrbitCamera : MonoBehaviour
{
	[SerializeField] private Transform lookAt;
	[SerializeField] private Transform follow;
	[SerializeField] private float distance;


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	private void LateUpdate()
    {
		if (follow != null)
		{
			// normalize follow's transform, then double it
			Vector3 direction = Vector3.Normalize(follow.position - lookAt.position);
			transform.position = follow.position + (direction * distance);

			// match the rotation of object that we're followings
			transform.rotation = follow.transform.rotation;
			transform.Rotate(90, 0, 0);
		}
	}
}

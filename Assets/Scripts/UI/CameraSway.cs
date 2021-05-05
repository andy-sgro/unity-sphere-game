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
 * NAME    : CameraSway
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class CameraSway : MonoBehaviour
{
	[SerializeField] private bool xAxis;
	[SerializeField] private bool yAxis;

	[SerializeField] private float xRange;
	[SerializeField] private float yRange;

	[SerializeField] private float speedDivisor = 2.0f;

	private float tolerance = 0.1f;



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
		xRange /= 2;
		yRange /= 2;
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
	private void LateUpdate()
    {
		if (xAxis)
		{
			float target = Input.GetAxisRaw("Horizontal") * xRange;
			float delta = ((TrigPhysics.SignedRoll(target - transform.localEulerAngles.y) * speedDivisor));

			if ((delta < -tolerance) | (delta > tolerance))
			{
				transform.Rotate(new Vector3(0, delta * Time.deltaTime, 0));
			}
		}

		if (yAxis)
		{
			float target = -Input.GetAxisRaw("Vertical") * yRange;
			float delta = ((TrigPhysics.SignedRoll(target - transform.localEulerAngles.x) * speedDivisor) );

			if ((delta < -tolerance) | (delta > tolerance))
			{
				transform.Rotate(new Vector3(delta * Time.deltaTime, 0, 0));
			}
		}
	}
}

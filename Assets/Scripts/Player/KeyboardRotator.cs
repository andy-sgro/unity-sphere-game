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
 * NAME    : KeyboardRotator
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class KeyboardRotator : MonoBehaviour
{
	[SerializeField] private float speed = 10;

	private float angle = 0;



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
		float xMove = Input.GetAxisRaw("Horizontal");
		float yMove = Input.GetAxisRaw("Vertical");

		switch (xMove)
		{
			case -1:
				switch (yMove)
				{
					case -1:
						angle = 225;
						break;

					case 0:
						angle = 270;
						break;

					case 1:
						angle = 315;
						break;

					default:
						break;
				}
				break;

			case 0:
				switch (yMove)
				{
					case -1:
						angle = 180;
						break;

					case 1:
						angle = 0;
						break;

					default:
						break;
				}
				break;

			case 1:
				switch (yMove)
				{
					case -1:
						angle = 135;
						break;

					case 0:
						angle = 90;
						break;

					case 1:
						angle = 45;
						break;

					default:
						break;
				}
				break;

			default:
				break;
		}
		transform.localRotation = Quaternion.Euler(0, angle, 0);
	}
}

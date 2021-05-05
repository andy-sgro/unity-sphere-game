/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Gives spherical objects a radius.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * NAME    : Radius
 * PURPOSE :
 *	- Gives spherical objects a radius.
 *	- Useful for globes that SurfaceTravellers travel on.
 */
public class Radius : MonoBehaviour
{
	[SerializeField] private float radius;


	/**
	 * \brief	Gets the private radius field.
	 * \return	Returns the private radius field.
	 */
	public float GetRadius()
	{
		return radius;
	}
}

/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Emits an explosion when the parent GameObject's HP reaches zero.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HP))]


/**
 * NAME    : ExplodeWhenDead
 * PURPOSE :
 *	- Emits an explosion when the parent GameObject's HP reaches zero.
 */
public class ExplodeOnDeath : MonoBehaviour
{
	[SerializeField] private GameObject explosionPrefab;
	[SerializeField] private GameObject explosionSound;


	/**
	 * \brief	Gets the HP component.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		GetComponent<HP>().AddDeathCallback(() => 
		{
			GameObject explosion = Instantiate(explosionPrefab);

			explosion.transform.position = transform.position;
			explosion.transform.rotation = transform.rotation;
			explosion.transform.parent = transform.parent;

			Instantiate(explosionSound);
		});
	}
}

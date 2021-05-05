/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: This class activates a GameObject when its HP goes to zero.
 */

using UnityEngine;

[RequireComponent(typeof(HP))]

/**
 * NAME    : ActivateOnDeath
 * PURPOSE :
 *	- This class activates an GameObject when its HP goes to zero.
 */
public class ActivateOnDeath : MonoBehaviour
{
	[SerializeField] private GameObject toActivate;

	/**
	 * \brief	Gets the HP component.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		GetComponent<HP>().AddDeathCallback(() => toActivate.SetActive(true));
	}
}

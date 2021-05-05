/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Increments a point when the parent GameObject dies.
 */

using UnityEngine;

[RequireComponent(typeof(HP))]


/**
 * NAME    : IncrementPointOnDeath
 * PURPOSE :
 *	- Increments a point when the parent GameObject dies.
 *	- This class connects to the EnemyCounter and HP classes.
 */
public class IncrementPointOnDeath : MonoBehaviour
{
	[SerializeField] private EnemyCounter enemiesLeft = null;

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
		GetComponent<HP>().AddDeathCallback(() => enemiesLeft.Decrement());
    }
}

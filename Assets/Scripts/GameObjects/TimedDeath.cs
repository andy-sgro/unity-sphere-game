/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Destroys the GameObject after a specified number of seconds.
 */

using UnityEngine;


/**
 * NAME    : TimedDeath
 * PURPOSE :
 *	- Destroys the GameObject after a specified number of seconds.
 */
public class TimedDeath : MonoBehaviour
{
	[SerializeField] private float timeTillDie;


	/**
	 * \brief	Destroys the GameObject after a specified number of seconds.
	 * \param	void
	 * \return	void
	 */
	private void FixedUpdate()
    {
		timeTillDie -= Time.fixedDeltaTime;
		if (timeTillDie <= 0)
		{
			Destroy(gameObject);
		}
	}
}

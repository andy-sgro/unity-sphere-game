/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: This class allows the player to control to main spaceship.
 */

using UnityEngine;

[RequireComponent(typeof(SphereTraveller))]


/**
 * NAME    : PlayerController
 * PURPOSE :
 *	- This class allows the player to control to main spaceship.
 */
public class PlayerController : MonoBehaviour
{
	private SphereTraveller st = null;


	/**
	 * \brief	Gets the SphereTraveller component.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		st = GetComponent<SphereTraveller>();
	}


	/**
	 * \brief	Allows the player to control to main spaceship.
	 * \param	void
	 * \return	void
	 */
	private void FixedUpdate()
	{
		// get keyboard input
		float xMove = Input.GetAxis("Horizontal") * st.speed;
		float yMove = Input.GetAxis("Vertical") * st.speed;
		st.Translate(xMove, yMove);
	}
}

/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Allows the player to rotate the PlayerController.
 */

using UnityEngine;


/**
 * NAME    : KeyboardRotator
 * PURPOSE :
 *	- Allows the player to rotate the PlayerController.
 */
public class KeyboardRotator : MonoBehaviour
{
	[SerializeField] private float speed = 10;
	private float angle = 0;


	/**
	 * \brief	Allows the player to rotate the PlayerController.
	 * \param	void
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

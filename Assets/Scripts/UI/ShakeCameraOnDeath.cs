/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Jolts the camera a bit when the player dies.
 */

using UnityEngine;

[RequireComponent(typeof(HP))]


/**
 * NAME    : ShakeCameraOnDeath
 * PURPOSE :
 *	- Jolts the camera a bit when the player dies.
 */
public class ShakeCameraOnDeath : MonoBehaviour
{
	[SerializeField] private Transform cam;
	[SerializeField] private float minShake;
	[SerializeField] private float maxShake;

	/**
	 * \brief	Adds a callback function to the HP component, so that
	 *			the camera shakes when the player's HP reaches zero.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		GetComponent<HP>().AddDeathCallback(() =>
		{
			float angle = Random.Range(-180, 179);
			float magnitude = Random.Range(minShake, maxShake);
			cam.Rotate(TrigPhysics.GetVelocity(angle, magnitude));
		});
    }
}

/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */

using UnityEngine;

[RequireComponent(typeof(HP))]


/**
 * NAME    : ShakeCameraOnDeath
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class ShakeCameraOnDeath : MonoBehaviour
{
	[SerializeField] private Transform cam;
	[SerializeField] private float minShake;
	[SerializeField] private float maxShake;

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
		GetComponent<HP>().AddDeathCallback(() =>
		{
			float angle = Random.Range(-180, 179);
			float magnitude = Random.Range(minShake, maxShake);
			cam.Rotate(TrigPhysics.GetVelocity(angle, magnitude));
		});
    }
}

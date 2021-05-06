/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Places the GameObject on a sphere randomly.
 */

using UnityEngine;


/**
 * NAME    : StartRandom
 * PURPOSE :
 *	- Places the GameObject on a sphere randomly.
 */
public class StartRandom : MonoBehaviour
{
	private SphereTraveller surfaceTraveller;


	/**
	 * \brief	Places the GameObject on a sphere randomly.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		surfaceTraveller = GetComponent<SphereTraveller>();
		float halfCir = (surfaceTraveller.Radius * Mathf.PI * Mathf.PI * 2) / Time.fixedDeltaTime;

		surfaceTraveller.Translate(Random.Range(-halfCir, halfCir), Random.Range(-halfCir, halfCir));
		surfaceTraveller.Rotate(Random.Range(-180, 180));
    }


}

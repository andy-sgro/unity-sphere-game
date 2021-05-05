/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: This class controls the enemy's AI, allowing them to move around.
 */

using UnityEngine;


/**
 * NAME    : EnemyAI
 * PURPOSE :
 *	- This class controls the enemy's AI, allowing them to move around.
 */
public class EnemyAI : MonoBehaviour
{
	[SerializeField] private float minInterval;
	[SerializeField] private float maxInterval;
	[SerializeField] private float angleVariance;

	private SphereTraveller surfaceTraveller;
	private float countDown = 0;		// seconds till change
	private float currAngleDelta = 0;	// changes angle
	private float angleDeltaDelta = 0;  // changes currAngleDelta
	private float targetAngleDelta = 0;


	/**
	 * \brief	Gets the SphericalTraveller component.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		surfaceTraveller = GetComponent<SphereTraveller>();
	}


	/**
	 * \brief	Moves the GameObject with AI.
	 * \param	void
	 * \return	void
	 */
	private void FixedUpdate()
	{
		float deltaTime = Time.fixedDeltaTime;

		// when countDown reaches 0, change angle and reset countDown
		if (countDown <= 0)
		{
			countDown = Random.Range(minInterval, maxInterval);
			currAngleDelta = targetAngleDelta;

			targetAngleDelta = Random.Range(-angleVariance, angleVariance);
			angleDeltaDelta = (targetAngleDelta - currAngleDelta) / countDown;
		}
		else
		{
			countDown -= deltaTime;
		}

		// adjust angleDelta
		currAngleDelta += (angleDeltaDelta * deltaTime);

		// move forward
		surfaceTraveller.Rotate(currAngleDelta);
		surfaceTraveller.Translate(0, surfaceTraveller.speed);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : MonoBehaviour
{
	public float minInterval;
	public float maxInterval;
	public float angleVariance;

	private SurfaceTraveller surfaceTraveller;
	private float countDown = 0;		// seconds till change
	private float currAngleDelta = 0;	// changes angle
	private float angleDeltaDelta = 0;  // changes currAngleDelta
	private float targetAngleDelta = 0;

	private void Start()
	{
		surfaceTraveller = GetComponent<SurfaceTraveller>();
	}

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSway : MonoBehaviour
{
	public bool xAxis;
	public bool yAxis;

	public float xRange;
	public float yRange;

	public float speedDivisor = 2.0f;

	private float tolerance = 0.1f;

	// Start is called before the first frame update
	void Start()
    {
		xRange /= 2;
		yRange /= 2;
	}

    // Update is called once per frame
    void LateUpdate()
    {
		if (xAxis)
		{
			float target = Input.GetAxisRaw("Horizontal") * xRange;
			float delta = ((UberPhysics.SignedRoll(target - transform.localEulerAngles.y) * speedDivisor));

			if ((delta < -tolerance) | (delta > tolerance))
			{
				transform.Rotate(new Vector3(0, delta * Time.deltaTime, 0));
			}
		}


		if (yAxis)
		{
			float target = -Input.GetAxisRaw("Vertical") * yRange;
			float delta = ((UberPhysics.SignedRoll(target - transform.localEulerAngles.x) * speedDivisor) );

			if ((delta < -tolerance) | (delta > tolerance))
			{
				transform.Rotate(new Vector3(delta * Time.deltaTime, 0, 0));
			}
		}


	}
}

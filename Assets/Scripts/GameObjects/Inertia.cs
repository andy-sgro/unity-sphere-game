using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inertia : MonoBehaviour
{
	private SphereTraveller st;

	private Vector2 inheritedVelocity;
	private Vector2 stdVelocity;
	private Quaternion inheritedAngle;
	private float angle;
	private bool init = false;
	private bool ready = false;
	private Transform geoTransform;



	private void Start()
    {
		st = (SphereTraveller)GetComponent<SphereTraveller>();
	}


	private void FixedUpdate()
    {
		if ((!init) & (ready))
		{
			init = true;
			geoTransform = transform.GetChild(0).gameObject.transform;
			geoTransform.Rotate(new Vector3(0, angle, 0));
		}
		else if (ready)
		{
			st.Translate(stdVelocity.x, stdVelocity.y);
			st.Translate(inheritedVelocity.x, inheritedVelocity.y);
		}
	}




	public Vector2 StdVelocity
	{
		get
		{
			return stdVelocity;
		}
		set
		{
			stdVelocity = value;
		}
	}

	public Vector2 InheritedVelocity
	{
		get
		{
			return inheritedVelocity;
		}
		set
		{
			inheritedVelocity = value;
		}
	}

	public float Angle
	{
		get
		{
			return angle;
		}
		set
		{
			angle = value;
			ready = true;
		}
	}

	public Quaternion InheritedAngle
	{
		get
		{
			return inheritedAngle;
		}
		set
		{
			inheritedAngle = value;
		}
	}
}

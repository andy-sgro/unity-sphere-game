
// src : https://answers.unity.com/questions/41050/how-can-i-make-movement-on-a-sphere.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceTraveller : MonoBehaviour
{
	public GameObject globe;
	public float speed;

	protected float angleDeg = 0.0f;
	protected float angleRad = 0.0f;
	protected Vector3 direction = Vector3.one;
	protected Quaternion rotation = Quaternion.identity;
	private float radius = 0;
	private Vector2 lastDirection;

	protected void Awake()
	{
		radius = globe.GetComponent<Radius>().radius;
	}

	private void Start()
	{
		lastDirection = new Vector2();
	}

	public void Rotate(float angleDelta)
	{
		angleDeg += angleDelta * Time.fixedDeltaTime;
		angleRad = angleDeg * Mathf.Deg2Rad;
		UpdateTransform();
	}

	public void Translate(float x, float y)
	{
		lastDirection = new Vector2(x, y);
		x = -x;

		direction = new Vector3(Mathf.Sin(angleRad), Mathf.Cos(angleRad));
		Vector3 perpendicular = new Vector3(-direction.y, direction.x);
		Quaternion verticalRotation = Quaternion.AngleAxis(y * Time.fixedDeltaTime, perpendicular);
		Quaternion horizontalRotation = Quaternion.AngleAxis(x * Time.fixedDeltaTime, direction);
		rotation *= horizontalRotation * verticalRotation;
		UpdateTransform();
	}

	private void UpdateTransform()
	{
		transform.localPosition = rotation * Vector3.forward * radius;
		transform.rotation = rotation * Quaternion.LookRotation(direction, Vector3.forward);
	}


	public float Radius
	{
		get
		{
			return radius;
		}
	}

	public float AngleRad
	{
		get
		{
			return angleRad;
		}
		set
		{
			angleDeg = value * Mathf.Rad2Deg;
			angleRad = value;
		}
	}

	public Quaternion Rotation
	{
		get
		{
			return rotation;
		}
		set
		{
			rotation = value;
		}
	}

	public Vector2 LastDirection
	{
		get
		{
			return lastDirection;
		}
		set
		{
			lastDirection = value;
		}
	}

}

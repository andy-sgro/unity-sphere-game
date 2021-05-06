/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Allows the parent GameObject to travel on globes like
 *				  Super Mario Galaxy.
 *				  src : https://answers.unity.com/questions/41050/how-can-i-make-movement-on-a-sphere.html
 */

using UnityEngine;


/**
 * NAME    : SurfaceTraveller
 * PURPOSE :
 *	- Allows the parent GameObject to travel on globes like
 *	  Super Mario Galaxy.
 */
public class SphereTraveller : MonoBehaviour
{
	[SerializeField] private GameObject globe;
	public float speed;

	public Vector2 LastDirection { get; private set; }

	[HideInInspector]
	public Quaternion Rotation = Quaternion.identity;

	private float angleDeg = 0.0f;
	private float angleRad = 0.0f;
	private Vector3 direction = Vector3.one;
	private float radius = 0;


	/**
	 * \brief	Gets the radius.
	 * \param	void
	 * \return	void
	 */
	protected void Awake()
	{
		radius = globe.GetComponent<Radius>().GetRadius();
	}


	/**
	 * \brief	Sets the last direction.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		LastDirection = new Vector2();
	}


	/**
	 * \brief	Rotates the surface traveller.
	 * \param	void
	 * \return	void
	 */
	public void Rotate(float angleDelta)
	{
		angleDeg += angleDelta * Time.fixedDeltaTime;
		angleRad = angleDeg * Mathf.Deg2Rad;
		UpdateTransform();
	}


	/**
	 * \brief	Moves around the globe.
	 * \param	float x : How far to travel horizontally.
	 * \param	float y : How far to travel vertically.
	 * \return	void
	 */
	public void Translate(float x, float y)
	{
		LastDirection = new Vector2(x, y);
		x = -x;

		direction = new Vector3(Mathf.Sin(angleRad), Mathf.Cos(angleRad));
		Vector3 perpendicular = new Vector3(-direction.y, direction.x);
		Quaternion verticalRotation = Quaternion.AngleAxis(y * Time.fixedDeltaTime, perpendicular);
		Quaternion horizontalRotation = Quaternion.AngleAxis(x * Time.fixedDeltaTime, direction);
		Rotation *= horizontalRotation * verticalRotation;
		UpdateTransform();
	}


	/**
	 * \brief	Moves around the a spherical plane.
	 * \param	void
	 * \return	void
	 */
	private void UpdateTransform()
	{
		transform.localPosition = Rotation * Vector3.forward * radius;
		transform.rotation = Rotation * Quaternion.LookRotation(direction, Vector3.forward);
	}


	/**
	 * \brief	Gets the radius.
	 * \return	Returns the radius.
	 */
	public float Radius
	{
		get
		{
			return radius;
		}
	}


	/**
	 * \brief	Gets and sets the angle in radians.
	 * \return	Returns the angle in radians.
	 */
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
}
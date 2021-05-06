/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Allows the player to shoot phaser beams.
 */

using UnityEngine;


/**
 * NAME    : Blaster
 * PURPOSE :
 *	- Allows the player to shoot phaser beams.
 */
public class Blaster : MonoBehaviour
{
	[SerializeField] private GameObject bulletPrefab;
	[SerializeField] private float angleSpread = 5;

	private float fireInterval = 0.015f;
	private float spread;
	private SphereTraveller st;
	private Transform turretTransform;


	/**
	 * \brief	Initilizes the fields.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		spread = angleSpread / 2;
		st = GetComponent<SphereTraveller>();
		turretTransform = transform.GetChild(1).gameObject.transform;
	}


	/**
	 * \brief	Fires bullets when the mouse button is pressed.
	 * \param	void
	 * \return	void
	 */
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			InvokeRepeating("Fire", float.Epsilon, fireInterval);
		}

		if (Input.GetMouseButtonUp(0))
		{
			CancelInvoke("Fire");
		}
	}


	/**
	 * \brief	Fires bullets.
	 * \param	void
	 * \return	void
	 */
	void Fire()
	{
		if (Time.timeScale != 0.0f)
		{
			GameObject bullet = Instantiate(bulletPrefab);

			bullet.transform.position = transform.position;
			bullet.transform.rotation = transform.rotation;
			bullet.GetComponentInParent<SphereTraveller>().Rotation = st.Rotation;
			Inertia inertia = bullet.GetComponentInParent<Inertia>();

			// get standard velocity
			float stdSpeed = bullet.GetComponentInParent<SphereTraveller>().speed;
			float stdAngle = turretTransform.localRotation.eulerAngles.y;
			inertia.StdVelocity = TrigPhysics.GetVelocity(stdAngle + Random.Range(-spread, spread), stdSpeed);

			// get inherited velocity
			inertia.InheritedVelocity = st.LastDirection;

			// get angle
			inertia.Angle = stdAngle;
		}
	}
}
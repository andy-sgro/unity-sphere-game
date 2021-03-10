﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
	public GameObject bulletPrefab;
	private float fireInterval = 0.015f;
	public float angleSpread = 5;

	private float spread;
	private List<GameObject> bullets = new List<GameObject>();
	private SurfaceTraveller st;
	private Transform turretTransform;

	private void Start()
	{
		spread = angleSpread / 2;
		st = (SurfaceTraveller)GetComponent<SurfaceTraveller>();
		turretTransform = transform.GetChild(1).gameObject.transform;
	}


	private void Update()
	{
		// Fire bullet code
		if (Input.GetMouseButtonDown(0))
		{
			InvokeRepeating("Fire", float.Epsilon, fireInterval);
		}

		if (Input.GetMouseButtonUp(0))
		{
			CancelInvoke("Fire");
		}
	}


	void Fire()
	{
		if (Time.timeScale != 0.0f)
		{
			GameObject bullet = Instantiate(bulletPrefab);

			bullet.transform.position = transform.position;
			bullet.transform.rotation = transform.rotation;
			bullet.GetComponentInParent<SurfaceTraveller>().Rotation = st.Rotation;

			// get standard velocity
			float stdSpeed = bullet.GetComponentInParent<SurfaceTraveller>().speed;
			float stdAngle = turretTransform.localRotation.eulerAngles.y;
			Vector2 stdVelocity = UberPhysics.GetVelocity(stdAngle + Random.Range(-spread, spread), stdSpeed);
			bullet.GetComponentInParent<Inertia>().StdVelocity = stdVelocity;

			// get inherited velocity
			bullet.GetComponentInParent<Inertia>().InheritedVelocity = st.LastDirection;

			// get angle
			bullet.GetComponentInParent<Inertia>().Angle = stdAngle;
		}
	}
}

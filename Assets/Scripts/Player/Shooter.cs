using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	public GameObject bulletPrefab;
	public float fireInterval = 0.05f;
	//public SphericProjectile prefab;

	private List<GameObject> bullets = new List<GameObject>();
	private SurfaceTraveller st;
	private Transform turretTransform;
	private bool hasAmmo = true;

	private void Start()
	{
		st = (SurfaceTraveller)GetComponent<SurfaceTraveller>();
		turretTransform = transform.GetChild(1).gameObject.transform;
	}


	private void Update()
	{
		// Fire bullet code
		if (hasAmmo & Input.GetMouseButtonDown(0))
		{
			//InvokeRepeating("Fire", float.Epsilon, fireInterval);
			Fire();
			hasAmmo = false;
		}

		if (!hasAmmo)
		{
			//CancelInvoke("Fire");
		}

		if (Input.GetMouseButtonUp(0))
		{
			hasAmmo = true;
		}
	}


	void Fire()
	{
		GameObject bullet = Instantiate(bulletPrefab);

		bullet.transform.position = transform.position;
		bullet.transform.rotation = transform.rotation;
		bullet.transform.parent = transform.parent;
		bullet.GetComponentInParent<SurfaceTraveller>().AngleRad = st.AngleRad;
		bullet.GetComponentInParent<SurfaceTraveller>().Rotation = st.Rotation;
		bullet.GetComponentInParent<SurfaceTraveller>().Rotate(-turretTransform.localRotation.eulerAngles.y);

	}
}

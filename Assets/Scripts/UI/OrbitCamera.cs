/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: This camera script centers itself on the PlayerController on a sphere.
 */

using UnityEngine;


/**
 * NAME    : OrbitCamera
 * PURPOSE :
 *	- This camera script centers itself on the PlayerController on a sphere.
 */
public class OrbitCamera : MonoBehaviour
{
	[SerializeField] private Transform lookAt;
	[SerializeField] private Transform follow;
	[SerializeField] private float distance;


	/**
	 * \brief	This function centers the camera on the PlayerController which is on the globe.
	 * \param	void
	 * \return	void
	 */
	private void LateUpdate()
    {
		if (follow != null)
		{
			// normalize follow's transform, then double it
			Vector3 direction = Vector3.Normalize(follow.position - lookAt.position);
			transform.position = follow.position + (direction * distance);

			// match the rotation of object that we're followings
			transform.rotation = follow.transform.rotation;
			transform.Rotate(90, 0, 0);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
	public Transform lookAt;
	public Transform follow;
	public float distance;

	private void Start()
	{

	}

    // Update is called once per frame
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

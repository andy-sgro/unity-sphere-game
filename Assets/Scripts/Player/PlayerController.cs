


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private SurfaceTraveller st;

	private void Start()
	{
		st = GetComponent<SurfaceTraveller>();
	}

	void FixedUpdate()
	{
		// get keyboard input
		float xMove = Input.GetAxis("Horizontal") * st.speed;
		float yMove = Input.GetAxis("Vertical") * st.speed;

		st.Translate(xMove, yMove);
	}

}

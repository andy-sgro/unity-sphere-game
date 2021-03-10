using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardRotator : MonoBehaviour
{
	public float speed = 10;

	private float angle = 0;
	
	// Start is called before the first frame update
    private void Start()
    {
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
		float xMove = Input.GetAxisRaw("Horizontal");
		float yMove = Input.GetAxisRaw("Vertical");

		switch (xMove)
		{
			case -1:
				switch (yMove)
				{
					case -1:
						angle = 225;
						break;

					case 0:
						angle = 270;
						break;

					case 1:
						angle = 315;
						break;

					default:
						break;
				}
				break;

			case 0:
				switch (yMove)
				{
					case -1:
						angle = 180;
						break;

					case 1:
						angle = 0;
						break;

					default:
						break;
				}
				break;

			case 1:
				switch (yMove)
				{
					case -1:
						angle = 135;
						break;

					case 0:
						angle = 90;
						break;

					case 1:
						angle = 45;
						break;

					default:
						break;
				}
				break;

			default:
				break;
		}

		transform.localRotation = Quaternion.Euler(0, angle, 0);
		
	}
}

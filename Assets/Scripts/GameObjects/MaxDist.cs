using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxDist : MonoBehaviour
{
	public float maxDist;

	private float distTravelled = 0;
	private bool toDelete = false;
	private Vector3 lastPos;
	
	// Start is called before the first frame update
    private void Start()
    {
		lastPos = transform.position;
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
		if (!toDelete)
		{
			Vector3 currPos = transform.position;
			distTravelled += Vector3.Distance(currPos, lastPos);
			lastPos = currPos;

			if (distTravelled >= maxDist)
			{
				toDelete = true;

				GameObject gameObject = this.gameObject;

				Destroy(gameObject);
			}
		}
	}
}

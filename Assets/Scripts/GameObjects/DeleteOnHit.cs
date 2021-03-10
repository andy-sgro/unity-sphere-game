﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnHit : MonoBehaviour
{
	public string tagToHit;

	private bool hit = false;

	// Start is called before the first frame update
	private void Start()
	{
		
	}

	// Update is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(tagToHit))
		{
			hit = true;
		}
	}

	private void LateUpdate()
	{
		if (hit)
		{
			Destroy(this.gameObject);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRandom : MonoBehaviour
{
	private SurfaceTraveller surfaceTraveller;

	// Start is called before the first frame update
	void Start()
	{
		surfaceTraveller = GetComponent<SurfaceTraveller>();


		float halfCir = (surfaceTraveller.Radius * Mathf.PI * Mathf.PI * 2) / Time.fixedDeltaTime;

		surfaceTraveller.Translate(Random.Range(-halfCir, halfCir), Random.Range(-halfCir, halfCir));
		surfaceTraveller.Rotate(Random.Range(-180, 180));
    }


}

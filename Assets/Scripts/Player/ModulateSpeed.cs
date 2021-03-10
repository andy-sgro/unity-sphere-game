using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulateSpeed : MonoBehaviour
{
	public float randomRange;

	private SurfaceTraveller st;
	
	// Start is called before the first frame update
    void Start()
    {
		st = (SurfaceTraveller)GetComponent<SurfaceTraveller>();
		st.speed += (Random.Range(0, randomRange) - (randomRange / 2));
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

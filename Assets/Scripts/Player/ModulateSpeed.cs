using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModulateSpeed : MonoBehaviour
{
	public float randomRange;

	private SphereTraveller st;
	
	// Start is called before the first frame update
    void Start()
    {
		st = (SphereTraveller)GetComponent<SphereTraveller>();
		st.speed += (Random.Range(0, randomRange) - (randomRange / 2));
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}

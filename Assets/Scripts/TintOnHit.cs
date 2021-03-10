using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


	private void OnCollisionEnter()
	{
		GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
	}


    // Update is called once per frame
    void Update()
    {
        
    }
}

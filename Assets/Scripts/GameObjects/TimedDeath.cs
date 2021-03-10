using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDeath : MonoBehaviour
{
	public float timeTillDie;
	
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		timeTillDie -= Time.fixedDeltaTime;
		if (timeTillDie <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}

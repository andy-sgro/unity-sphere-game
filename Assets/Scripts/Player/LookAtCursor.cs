using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Time.timeScale != 0.0f)
		{
			transform.localRotation = Quaternion.Euler(0, Cursor.Angle, 0);
		}
    }
}

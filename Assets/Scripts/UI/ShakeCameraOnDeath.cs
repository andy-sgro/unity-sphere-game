using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCameraOnDeath : MonoBehaviour
{
	public Transform cam;
	public float minShake;
	public float maxShake;

	private HP hp;
	
	// Start is called before the first frame update
    void Start()
    {
		hp = (HP)GetComponent<HP>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.hp <= 0)
		{
			float angle = Random.Range(-180, 179);
			float magnitude = Random.Range(minShake, maxShake);
			cam.Rotate(UberPhysics.GetVelocity(angle, magnitude));
		}
    }
}

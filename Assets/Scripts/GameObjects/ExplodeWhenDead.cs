using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeWhenDead : MonoBehaviour
{
	public GameObject explosionPrefab;
	public GameObject explosionSound;

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
			GameObject explosion = Instantiate(explosionPrefab);

			explosion.transform.position = transform.position;
			explosion.transform.rotation = transform.rotation;
			explosion.transform.parent = transform.parent;

			GameObject sound = Instantiate(explosionSound);
		}
    }
}

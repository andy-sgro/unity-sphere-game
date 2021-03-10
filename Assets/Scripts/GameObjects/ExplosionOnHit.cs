using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnHit : MonoBehaviour
{
	public GameObject explosionPrefab;
	public string tagToHit;

	private HP hp;

	// Start is called before the first frame update
	void Start()
    {
		hp = (HP)GetComponent<HP>();

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag(tagToHit) & (hp.hp != 0))
		{
			GameObject explosion = Instantiate(explosionPrefab);

			explosion.transform.position = transform.position;
			explosion.transform.rotation = transform.rotation;
			explosion.transform.parent = transform.parent;
		}
	}
}

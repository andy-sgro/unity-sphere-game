using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseHpOnHit : MonoBehaviour
{
	public string tagToHit;

	private HP hp;
	
	// Start is called before the first frame update
    private void Start()
    {
		hp = (HP)GetComponent<HP>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag(tagToHit))
		{
			--hp.hp;
		}
	}
}

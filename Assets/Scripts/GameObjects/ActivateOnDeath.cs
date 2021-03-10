using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnDeath : MonoBehaviour
{
	public GameObject toActivate;

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
			toActivate.SetActive(true);
		}
	}
}

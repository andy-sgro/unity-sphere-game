using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteWhenDead : MonoBehaviour
{
	private HP hp;

	// Start is called before the first frame update
	void Start()
    {
		hp = (HP)GetComponent<HP>();
	}

    // Update is called once per frame
    void LateUpdate()
    {
        if (hp.hp <= 0)
		{
			Destroy(this.gameObject);
		}
    }
}

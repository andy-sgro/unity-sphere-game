using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementPointOnDeath : MonoBehaviour
{
	public GameObject pointKeeper;

	private HP hp;
	private Points points;
	private bool gavePoints = false;
	
	// Start is called before the first frame update
    void Start()
    {
		hp = (HP)GetComponent<HP>();
		points = (Points)pointKeeper.GetComponent<Points>();

    }

    // Update is called once per frame
    void Update()
    {
		if ((hp.hp <= 0) & (!gavePoints))
		{
			gavePoints = true;
			Points.PointsToWin -= 1;
		}
    }
}

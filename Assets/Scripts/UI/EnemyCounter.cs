/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/**
 * NAME    : Points
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class EnemyCounter : MonoBehaviour
{
	[SerializeField] private GameObject toActivate;
	[SerializeField] private TextMeshProUGUI textBox;
	[SerializeField] private GameObject objToDuplicate = null;
	[SerializeField] private int numEnemies = 0;


	void Start()
	{
		if ((numEnemies < 1) | (objToDuplicate == null))
		{
			Debug.LogWarning("Duplicator script has invalid negative/null field values.");
		}
		else
		{
			textBox.text = "Enemies left: " + numEnemies;

			for (int i = 1; i < numEnemies; ++i)
			{
				Instantiate(objToDuplicate, transform);
			}
		}
	}


	public void Decrement()
	{
		--numEnemies;
		textBox.text = "Enemies left: " + numEnemies;
		if (numEnemies <= 0)
		{
			toActivate.SetActive(true);
		}
	}
}

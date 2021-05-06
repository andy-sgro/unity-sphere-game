/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Duplicates the enemy GameObject and keeps track of how many there are,
 *				  displaying a 'YOU WIN' screen when all enemies are killed.
 */

using UnityEngine;
using TMPro;


/**
 * NAME    : Points
 * PURPOSE :
 *	- Duplicates the enemy GameObject and keeps track of how many there are.
 *	- Displays a 'YOU WIN' screen when all enemies are killed.
 */
public class EnemyCounter : MonoBehaviour
{
	[SerializeField] private GameObject toActivate;
	[SerializeField] private TextMeshProUGUI textBox;
	[SerializeField] private GameObject objToDuplicate = null;
	[SerializeField] private int numEnemies = 0;


	/**
	 * \brief	Duplicates the enemy GameObject.
	 * \param	void
	 * \return	void
	 */
	private void Start()
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


	/**
	 * \brief	Decrements the enemy count. If the enemy count is zero, then display the
	 *			'YOU WIN' screen.
	 * \param	void
	 * \return	void
	 */
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

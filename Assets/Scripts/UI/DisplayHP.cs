/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Displays the player's HP on the HUD overlay.
 */

using UnityEngine;
using TMPro;

[RequireComponent(typeof(HP))]


/**
 * NAME    : DisplayHP
 * PURPOSE :
 *	- Displays the player's HP on the HUD overlay.
 *	- This class connects to the HP class.
 */
public class DisplayHP : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI textBox;


	/**
	 * \brief	Initilizes the HP textbox on the HUD overlay, and sets up a callback function so that
	 *			the HP textbox gets updated every time the player's HP gets decremented.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
		HP hp = GetComponent<HP>();
		textBox.text = "Lives: " + hp.hp;
		hp.AddDecrementCallback((hp) => textBox.text = "Lives: " + hp);
    }
}

/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: 
 */
using UnityEngine;
using TMPro;

[RequireComponent(typeof(HP))]


/**
 * NAME    : DisplayHP
 * PURPOSE :
 *	- Purpose, what it does
 *	- What it's features are
 *	- How it relates to other classes
 */
public class DisplayHP : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI textBox;


	/**
	 * \brief	
	 * 
	 * \detail
	 * 
	 * \param	void
	 * 
	 * \return	void
	 */
	private void Start()
    {
		HP hp = GetComponent<HP>();
		textBox.text = "Lives: " + hp.hp;
		hp.AddDecrementCallback((hp) => textBox.text = "Lives: " + hp);
    }
}

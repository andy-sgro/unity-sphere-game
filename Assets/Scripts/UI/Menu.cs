/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Provides functionality to the Menu buttons,
 *				  such as loading a new level and quitting the applicaiton.
 */

using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * NAME    : Menu
 * PURPOSE :
 *	- Provides functionality to the Menu buttons.
 *	- Allows for loading a new level and quitting the applicaiton.
 */
public class Menu : MonoBehaviour
{
	/**
	 * \brief	Loads the first level.
	 * \param	void
	 * \return	void
	 */
	public void LoadGame()
    {
        SceneManager.LoadScene("Level 1 Preloader");
    }


	/**
	 * \brief	Loads the main menu.
	 * \param	void
	 * \return	void
	 */
	public void LoadMenu()
	{
		SceneManager.LoadScene("Main Menu");
	}


	/**
	 * \brief	Quits the application.
	 * \param	void
	 * \return	void
	 */
	public void QuitGame()
    {
        Application.Quit();
    }
}

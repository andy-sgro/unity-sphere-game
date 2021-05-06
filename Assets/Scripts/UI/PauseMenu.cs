/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Allows the pause menu to pause and resume the game.
 */

using UnityEngine;


/**
 * NAME    : PauseMenu
 * PURPOSE :
 *	- Allows the pause menu to pause and resume the game.
 */
public class PauseMenu : MonoBehaviour
{
	[SerializeField] private GameObject pauseMenuUI;
	private bool paused = false;


	/**
	 * \brief	Initilizes the pause menu's variables.
	 * \param	void
	 * \return	void
	 */
	private void Awake()
	{
		paused = false;
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
	}


	/**
	 * \brief	Toggles the pause functionality when the ESCPAPE key is pressed.
	 * \param	void
	 * \return	void
	 */
	private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (paused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
    }


	/**
	 * \brief	Unpauses the game.
	 * \param	void
	 * \return	void
	 */
	public void Resume()
	{
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		paused = false;
	}


	/**
	 * \brief	Pauses the game.
	 * \param	void
	 * \return	void
	 */
	public void Pause()
	{
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		paused = true;
	}
}

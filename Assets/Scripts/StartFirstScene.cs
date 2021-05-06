/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 5, 2021
 * DESCRIPTION	: Loads the first scene.
 */

using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * NAME    : StartFirstScene
 * PURPOSE :
 *	- Loads the first scene if it hasn't already been loaded before.
 *	- This script should be placed in the first scene, as well as all other relevant scenes.
 */
public class StartFirstScene : MonoBehaviour
{
    private static bool loadedFirstScene = false;

	/**
	 * \brief	Loads the first scene if it hasn't already been loaded before.
	 * \param	void
	 * \return	void
	 */
	private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            loadedFirstScene = true;
        }
		else if (!loadedFirstScene)
		{
			SceneManager.LoadScene(0);
		}
    }
}

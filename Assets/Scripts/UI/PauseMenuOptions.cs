using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour {

	public GameObject controller;

	private PauseMenu pauseMenu;


	private void Start()
	{
		pauseMenu = (PauseMenu)GetComponent<PauseMenu>();
	}

	public void Restart()
	{
		SceneManager.LoadScene("Level 1 Preloader");
	}

    public void LoadMenu()
    {
        SceneManager.LoadScene("main menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFirstScene : MonoBehaviour
{
    private static bool loadedFirstScene = false;
    
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

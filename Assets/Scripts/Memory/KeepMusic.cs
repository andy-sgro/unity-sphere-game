using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepMusic : MonoBehaviour
{
    void Awake()
    {
		DontDestroyOnLoad(gameObject);
		AudioSource audio = gameObject.GetComponent<AudioSource>();
		if (audio != null)
		{
			Global.music = audio;
			Global.maxMusicVolume = audio.volume;
		}
    }

}

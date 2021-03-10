using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public static int pointsToWin = 20;
	public GameObject toActivate;
	public TextMeshProUGUI textBox;

	public static int enemiesLeft;

	// Start is called before the first frame update
	void Start()
    {
		enemiesLeft = pointsToWin;
	}

    // Update is called once per frame
    void Update()
    {
		textBox.text = "Enemies left: " + enemiesLeft;

		if (enemiesLeft <= 0)
		{
			toActivate.SetActive(true);
		}
    }

	public static int PointsToWin
	{
		get
		{
			return enemiesLeft;
		}
		set
		{
			enemiesLeft = value;
		}
	}

}

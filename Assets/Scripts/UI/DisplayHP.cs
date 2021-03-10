using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHP : MonoBehaviour
{
	public TextMeshProUGUI textBox;

	private HP hp;

	// Start is called before the first frame update
	void Start()
    {
		hp = (HP)GetComponent<HP>();
    }

    // Update is called once per frame
    void Update()
    {
		textBox.text = "Lives: " + hp.hp;
	}


}

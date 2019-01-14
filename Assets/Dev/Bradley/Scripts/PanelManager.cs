using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    public GameObject introPanel;

    [SerializeField]
    public GameObject gamePanel;

	void Start ()
    {
        introPanel.SetActive(true);
        gamePanel.SetActive(false);
	}
	
	void Update ()
    {
		if (Input.anyKey || Input.GetMouseButton(0))
        {
            introPanel.SetActive(false);
            gamePanel.SetActive(true);
        }
	}
}

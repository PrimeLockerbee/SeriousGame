using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject introPanel;

    [SerializeField]
    private GameObject gamePanel;

    [SerializeField]
    private GameTimer m_Timer;

    void Start()
    {
        introPanel.SetActive(true);
        gamePanel.SetActive(false);

        m_Timer = GetComponent<GameTimer>();
    }
	
	void Update ()
    {
		if (Input.anyKey || Input.GetMouseButton(0))
        {
            introPanel.SetActive(false);
            gamePanel.SetActive(true);

            if (m_Timer.m_GameTime > 60f)
            {
                m_Timer.m_GameTime = 60f;
            }
        }
	}
}

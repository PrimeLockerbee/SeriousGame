using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{
    float m_GameTime = 60.0f;

    [SerializeField]
    private TextMeshProUGUI m_TimerText;

    void Update()
    {
        m_GameTime -= Time.deltaTime;

        m_TimerText.text = m_GameTime.ToString("f0"); ;

        if (m_GameTime < 0)
            GameOver();
    }

    void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}

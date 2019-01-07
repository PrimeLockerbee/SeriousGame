using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterControl : MonoBehaviour
{
    private int m_ph;
    public int m_amplitude;

    private float m_waterTimer;
    public float m_startWaterTimer;

    private float m_gameTimer;
    public float m_MaxGameTimer;
    private int m_intGameTimer;

    [SerializeField]
    private TextMeshPro m_WaterText;

	void Start ()
    {
        m_waterTimer = m_startWaterTimer;
        m_gameTimer = m_MaxGameTimer;
	}
	void Update ()
    {
        //GameTimer
        //m_gameTimer -= Time.deltaTime;
        //Debug.Log(m_gameTimer);
        
        //Phtext
        m_WaterText.text = m_ph.ToString();
        //random water generator
        if (m_waterTimer < 0)
        {
            m_amplitude = Random.Range(-10, 10);
            m_ph += m_amplitude;
            m_waterTimer = m_startWaterTimer;
        }
        else
        {
            m_waterTimer -= Time.deltaTime;
        }
        if (m_ph >= 10 || m_ph <= -10)
        {
            Debug.Log("they're something wrong, fix it");
        }
        if (m_ph >= 15 || m_ph <= 15)
        {
            Debug.Log("You lose");
        }
	}

    public void NegativeButton()
    {
        m_ph -= 5;
    }

    public void PositiveButton()
    {
        m_ph += 5;
    }
}

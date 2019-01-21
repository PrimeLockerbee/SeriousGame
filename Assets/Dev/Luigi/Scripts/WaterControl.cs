using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

enum WaterState
{
    schoon,
    beetjeVies,
    redelijkVies,
    ergVies
}

enum TextState
{
    tooPositive,
    tooNegative
}

public class WaterControl : MonoBehaviour
{
    //Assign State
    private WaterState m_state;
    //Assign text State
    private TextState m_textState;

    //Assign warning text
    [SerializeField]
    private GameObject m_InBalans;
    [SerializeField]
    private GameObject m_tooHigh;
    [SerializeField]
    private GameObject m_tooLow;

    //animator
    private float m_waterState;

    //assign water
    [SerializeField]
    private Animator m_UpperWater;
    [SerializeField]
    private Animator m_LowerWater;

    //Ph management
    public int m_ph;
    private int m_amplitude;
    //timer to switch ph amount
    private float m_waterTimer;
    public float m_startWaterTimer;
    
    //UI elements
    [SerializeField]
    private TextMeshProUGUI m_WaterText;
    [SerializeField]
    private GameObject m_phBar;

    void Start ()
    {
        m_waterTimer = m_startWaterTimer;
        m_ph = 0;

    }
	void Update ()
    {
        //Phtext
        m_WaterText.text = m_ph.ToString();
        //PhBar
        if (m_ph < 25 || m_ph > -25)
        { 
            m_phBar.transform.position = new Vector2(m_phBar.transform.position.x, (m_ph + 25f) / 10f);
        }
        //random water generator
        if (m_waterTimer < 0)
        {
            m_amplitude = Random.Range(-15, 15);
            m_ph += m_amplitude;
            m_waterTimer = m_startWaterTimer;
        }
        else
        {
            m_waterTimer -= Time.deltaTime;
        }
        #region Lose requirement
        if (m_ph >= 25)
        {
            m_ph = 25;
            Debug.Log("You lose");
        }
        else if (m_ph <= -25)
        {
            m_ph = -25;
            Debug.Log("You lose");
        }
        #endregion
        //Debug lines
        if (m_ph >= 14)
        {
            m_InBalans.SetActive(false);
            m_tooHigh.SetActive(true);
            m_tooLow.SetActive(false);
            m_textState = TextState.tooPositive;
            if (m_ph <= 20)
            {
                m_state = WaterState.beetjeVies;       
            }
            else
            {
                m_state = WaterState.redelijkVies;
            }
        }
        else if (m_ph <= -12)
        {
            m_InBalans.SetActive(false);
            m_tooHigh.SetActive(false);
            m_tooLow.SetActive(true);
            m_textState = TextState.tooNegative;
            if (m_ph <= 20)
            {
                m_state = WaterState.redelijkVies;
            }
            else
            {
                m_state = WaterState.ergVies;
            }
        }
        else
        {
            m_InBalans.SetActive(true);
            m_tooHigh.SetActive(false);
            m_tooLow.SetActive(false);
            m_state = WaterState.schoon;
        }
        //Animator State
        m_UpperWater.SetFloat("WaterState", m_waterState);
        m_LowerWater.SetFloat("WaterState", m_waterState);
        if (m_state == WaterState.schoon)
        {
            m_waterState = 0f;
        }
        else if (m_state == WaterState.beetjeVies)
        {
            m_waterState = 1f;
        }
        else if (m_state == WaterState.redelijkVies)
        {
            m_waterState = 2f;
        }
        else if (m_state == WaterState.ergVies)
        {
            m_waterState = 3f;
        }
    }
}

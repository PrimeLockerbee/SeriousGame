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
    //private GameObject m_warningText;
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
            //m_potion.gameObject.SetActive(true);
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
            //m_warningText.SetActive(true);
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
            //m_warningText.SetActive(true);
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
            //m_warningText.SetActive(false);
            m_state = WaterState.schoon;
        }
	}
}

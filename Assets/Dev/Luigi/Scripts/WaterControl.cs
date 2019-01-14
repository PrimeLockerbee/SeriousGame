using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterControl : MonoBehaviour
{
    //Ph management
    public int m_ph;
    private int m_amplitude;
    //timer to switch ph amount
    private float m_waterTimer;
    public float m_startWaterTimer;

    //UI elements
    [SerializeField]
    private TextMeshPro m_WaterText;
    [SerializeField]
    private GameObject m_phBar;

    //Assign Potion
    public PotionUseScript m_potion;

    void Start ()
    {
        m_waterTimer = m_startWaterTimer;
	}
	void Update ()
    {
        Debug.Log(m_potion.gameObject.name);
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
            Debug.Log("kijk uit ph is te hoog!");
        }
        else if (m_ph <= -12)
        {
            Debug.Log("kijk uit ph is te laag!");
        }
        else
        {
            Debug.Log("ph is in balans");
        }
	}
}

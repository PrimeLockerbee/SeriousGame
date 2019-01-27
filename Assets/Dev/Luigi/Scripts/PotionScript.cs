using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    //GameManager
    [SerializeField]
    private WaterControl m_waterManager;
    //Potion Lists
    public List<GameObject> m_PpotionList;
    public List<GameObject> m_NpotionList;
    //Assign potion positions
    [SerializeField]
    public GameObject m_Npos1;
    [SerializeField]
    public GameObject m_Npos2;
    [SerializeField]
    public GameObject m_Ppos1;
    [SerializeField]
    public GameObject m_Ppos2;
    //Check if bar is filled
    public bool m_pBarFilled;
    public bool m_nBarFilled;

    void Start ()
    {
        m_pBarFilled = false;
    }
	void Update ()
    {
        //rules for positive potion list
        if (!m_pBarFilled)
        {
            int rndm = Random.Range(0, m_PpotionList.Count);
            if (m_Ppos1.transform.childCount == 0)
            {
                if (!m_PpotionList[rndm].activeSelf)
                {
                    m_PpotionList[rndm].SetActive(true);
                    m_PpotionList[rndm].transform.SetParent(m_Ppos1.transform);
                }
            }
            else if (m_Ppos2.transform.childCount == 0)
            {
                if (!m_PpotionList[rndm].activeSelf)
                {
                    m_PpotionList[rndm].SetActive(true);
                    m_PpotionList[rndm].transform.SetParent(m_Ppos2.transform);
                }
            }
            else
            {
                m_pBarFilled = true;
            }
        }
        //rules for negative potion list
        if (!m_nBarFilled)
        {
            int rndm = Random.Range(0, m_NpotionList.Count);
            if (m_Npos1.transform.childCount == 0)
            {
                if (!m_NpotionList[rndm].activeSelf)
                {
                    m_NpotionList[rndm].SetActive(true);
                    m_NpotionList[rndm].transform.SetParent(m_Npos1.transform);
                }
            }
            else if (m_Npos2.transform.childCount == 0)
            {
                if (!m_NpotionList[rndm].activeSelf)
                {
                    m_NpotionList[rndm].SetActive(true);
                    m_NpotionList[rndm].transform.SetParent(m_Npos2.transform);
                }
            }
            else
            {
                m_nBarFilled = true;
            }
        }
    }
    #region Assign Buttons
    //Positive Buttons
    public void Plus3()
    {
        m_waterManager.m_ph += 3;
    }
    public void Plus4()
    {
        m_waterManager.m_ph += 4;
    }
    public void Plus5()
    {
        m_waterManager.m_ph += 5;
    }
    public void Plus7()
    {
        m_waterManager.m_ph += 7;
    }
    public void Plus8()
    {
        m_waterManager.m_ph += 8;
    }
    public void Plus9()
    {
        m_waterManager.m_ph += 9;
    }
    //Negative Buttons
    public void Min3()
    {
        m_waterManager.m_ph -= 3;
    }
    public void Min4()
    {
        m_waterManager.m_ph -= 4;
    }
    public void Min5()
    {
        m_waterManager.m_ph -= 5;
    }
    public void Min7()
    {
        m_waterManager.m_ph -= 7;
    }
    public void Min8()
    {
        m_waterManager.m_ph -= 8;
    }
    public void Min9()
    {
        m_waterManager.m_ph -= 9;
    }
    #endregion
}

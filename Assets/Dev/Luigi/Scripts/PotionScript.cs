﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pooling;

public class PotionScript : MonoBehaviour
{
    [SerializeField]
    private WaterControl m_waterManager;
    
    public List<GameObject> m_PpotionList;

    
    public List<GameObject> m_NpotionList;

    public List<ListInList> m_list;
    [SerializeField]
    private GameObject m_Pcanvas;
    [SerializeField]
    private GameObject m_Ncanvas;

    private int m_listCount = 2;
    
    //private int m_randomizer;

    void Start ()
    {
    }
	void Update ()
    {
        Debug.Log(m_PpotionList.Count);
        Debug.Log(m_NpotionList.Count);
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

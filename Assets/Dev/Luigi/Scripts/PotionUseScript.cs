using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUseScript : MonoBehaviour
{
    private GameObject m_potion;
    [SerializeField]
    private WaterControl m_controller;

    [SerializeField]
    private bool m_isPositive;

    private GameObject m_manager;
    private PotionScript m_potionScript;

    void Start ()
    {
        m_potion = this.gameObject;
        m_controller = GetComponent<WaterControl>();

        m_manager = GameObject.FindGameObjectWithTag("Manager");
        m_potionScript = m_manager.GetComponent<PotionScript>();

        if (m_isPositive)
        {
            m_potionScript.m_PpotionList.Add(gameObject);
        }

        else
        {
            m_potionScript.m_NpotionList.Add(gameObject);
        }
	}
	void Update ()
    {
	}
    public void OnClick()
    {
        m_potion.SetActive(false);
    }
    private void OnBecameVisible()
    {
        //this.transform.position
    }
}

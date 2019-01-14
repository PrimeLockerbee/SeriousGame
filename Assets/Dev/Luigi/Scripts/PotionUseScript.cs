using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUseScript : MonoBehaviour
{
    private GameObject m_potion;
    private WaterControl m_controller;

    void Start ()
    {
        m_potion = this.gameObject;
        m_controller = GetComponent<WaterControl>();
	}
	void Update ()
    {
	}
    public void OnClick()
    {
        m_potion.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUseScript : MonoBehaviour
{
    //Set name for this gameobject
    private GameObject m_potion;
    [SerializeField]
    private WaterControl m_controller;
    //check if amplitude on potionn is positive
    [SerializeField]
    private bool m_isPositive;
    //Assign manager and potion script
    private GameObject m_manager;
    private PotionScript m_potionScript;

    //Assign Canvas
    [SerializeField]
    private GameObject m_canvas;

    void Start ()
    {
        //Set this gameObject and it's position
        m_potion = this.gameObject;
        m_potion.transform.SetParent(m_canvas.transform);
        //Gettinng Components
        m_controller = GetComponent<WaterControl>();
        m_manager = GameObject.FindGameObjectWithTag("Manager");
        m_potionScript = m_manager.GetComponent<PotionScript>();
        //fill lists
        if (m_isPositive)
        {
            m_potionScript.m_PpotionList.Add(gameObject);
            m_potion.SetActive(false);
        }
        else
        {
            m_potionScript.m_NpotionList.Add(gameObject);
            m_potion.SetActive(false);
        }
	}
	void Update ()
    {
        //Set position of parent
        if (transform.parent != null)
        {
            this.transform.position = transform.parent.position;
        }
	}
    //Setting itself inactive and apply it onn the canvas
    public void OnClick()
    {
        m_potion.transform.SetParent(m_canvas.transform);
        m_potion.SetActive(false);
    }
    //set position of parent
    private void OnBecameVisible()
    {
        this.transform.position = transform.parent.position;
    }
}

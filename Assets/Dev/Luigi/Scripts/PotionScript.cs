using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pooling;

public class PotionScript : MonoBehaviour
{
    private WaterControl m_waterManager;
    public List<GameObject> m_PpotionList;
    public List<GameObject> m_NpotionList;

    public List<ListInList> m_list;
    [SerializeField]
    private GameObject m_Pcanvas;
    [SerializeField]
    private GameObject m_Ncanvas;

    private int m_listCount = 2;
    
    private int m_randomizer;

    void Start ()
    {
        //m_list.Count = m_randomizer;

        for (int i = 0; i < m_list.Count; i++)
        {
            if (i == 0)
            {
                for (int j = 0; j < m_list[0].Object.Count; j++)
                {
                    GameObject obj = (GameObject)Instantiate(m_list[0].Object[j].gameObject, m_Pcanvas.transform);
                    obj.SetActive(true);
                    m_PpotionList.Add(obj);
                }
            }
            if (i == 1)
            {
                for (int j = 0; j < m_list[1].Object.Count; j++)
                {
                    GameObject obj = (GameObject)Instantiate(m_list[1].Object[j].gameObject, m_Ncanvas.transform);
                    obj.SetActive(true);
                    m_NpotionList.Add(obj);
                }
            }
        }
    }
	void Update ()
    {
        switch (m_listCount)
        {
            case 0:
                m_NpotionList[0].SetActive(false);
                m_NpotionList[0].SetActive(true);
                break;
        }
    }
}

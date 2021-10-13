using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameObject m_upperLimit;
    private GameObject m_bottomLimit;

    public GameObject UpperLimit => m_upperLimit;
    public GameObject BottomLimit => m_bottomLimit;

    private void Awake()
    {
        m_upperLimit = GameObject.FindWithTag("UpperLimit");
        m_bottomLimit = GameObject.FindWithTag("BottomLimit");
        GameManager.Instance.LevelInitialization(this);
    }
    
}



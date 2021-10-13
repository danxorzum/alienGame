using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   
    private static GameManager m_instance;

    public static GameManager Instance
    {
        get
        {
            if (m_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                m_instance = go.AddComponent<GameManager>();
            }

            return m_instance;
        }
    }

    private LevelManager m_currentLevelManager;

    public GameObject UpperLimit => m_currentLevelManager.UpperLimit;
    public GameObject BottomLimit => m_currentLevelManager.BottomLimit;
    
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LevelInitialization(LevelManager lm)
    {
        m_currentLevelManager = lm;
    }
}

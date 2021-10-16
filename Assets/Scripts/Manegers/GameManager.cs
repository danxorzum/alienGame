using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Player player;
    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;

    private static GameManager m_instance;
    public float time;

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
        time = 300;
        DontDestroyOnLoad(this.gameObject);
    }

    public void LevelInitialization(LevelManager lm)
    {
        m_currentLevelManager = lm;
    }
    private void Update()
    {
        switch (player.lives)
        {
            case 4: l5.active = false;break;
            case 3: l4.active = false;break;
            case 2: l3.active = false;break;
            case 1: l2.active = false;break;
           
        }
        time -= Time.deltaTime;
    }
    public int GetTime() => (int)time;
}

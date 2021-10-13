using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform m_spawnpoint;
    public GameObject m_bullet;

    private InputHandler m_input;

    public float m_coldDownDuration = 0.5f;
    public float m_KerFramePoint = 0.5f;
    private void Start()
    {
        m_input = gameObject.GetComponent<InputHandler>();
    }
    public void Shoot()
    {
        Instantiate(m_bullet, m_spawnpoint.position,m_spawnpoint.rotation);

    }

    private void Update()
    {
        if (m_input.FireButton)
        {
            if (m_KerFramePoint <= Time.timeSinceLevelLoad)
                Shoot();
            m_KerFramePoint = Time.timeSinceLevelLoad + m_coldDownDuration;
        }
    }
}

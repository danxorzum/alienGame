using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform m_spawnpoint;
    public GameObject m_bullet;
    public Transform gun;
    public float power;

    AudioSource audio;
    private InputHandler m_input;

    public float m_coldDownDuration = 0.5f;
    public float m_KerFramePoint = 0.5f;
    private void Start()
    {
        m_input = gameObject.GetComponent<InputHandler>();
        audio= gameObject.GetComponent<AudioSource>();
    }
    public void Shoot()
    {
        audio.Play();
        Bullet bulllet = Instantiate(m_bullet, gun.position,gun.rotation).GetComponent<Bullet>();
        bulllet.Shoot(power);

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

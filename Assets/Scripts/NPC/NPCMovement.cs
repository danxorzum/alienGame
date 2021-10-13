using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(NPCInputs))]

public class NPCMovement : MonoBehaviour
{
    public float m_speed = 10.0f;

    private InputHandler m_input;
    // Start is called before the first frame update
    void Start()
    {
        m_input = gameObject.GetComponent<NPCInputs>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if (m_input == null) return;

        transform.Translate(new Vector3(m_input.GetAxis.x * (m_speed * Time.deltaTime),
            m_input.GetAxis.y * (m_speed * Time.deltaTime), 0));
    }
}

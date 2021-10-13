using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInputs : InputHandler
{
    public Vector2 m_actionAxis = Vector2.zero;

    private void Start()
    {
        m_axis = m_actionAxis;
    }
}

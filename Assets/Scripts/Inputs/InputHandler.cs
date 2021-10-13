using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputHandler : MonoBehaviour
{
    protected Vector2 m_axis = Vector2.zero;
    protected bool m_fireButton = false;
    public Vector2 GetAxis => m_axis;
    public bool FireButton => m_fireButton;
}

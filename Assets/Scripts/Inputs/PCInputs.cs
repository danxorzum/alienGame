using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10)]

public class PCInputs : InputHandler
{

    // Update is called once per frame
    void Update()
    {
        m_axis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        m_fireButton = Input.GetButton("Jump");
    }
}

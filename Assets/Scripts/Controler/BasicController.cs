using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour
{
    public Vector2 m_speed = new Vector2(10.0f, 10.0f);

    private InputHandler m_input;
  
    void Awake()
    {
#if UNITY_STANDALONE || UNITY_EDITOR
        m_input = gameObject.AddComponent<PCInputs>();
#elif UNITY_ANDRIOD || UNITY_IOS
        m_input = gameObject.AddComponent<TouchInputs>();
#endif
    }




    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.position = new Vector3(transform.position.x-m_speed*Time.deltaTime, transform.position.y, 0);
        //}
        //ielse f(Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position = new Vector3(transform.position.x+m_speed*Time.deltaTime, transform.position.y, 0);
        //}

        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y+m_speed*Time.deltaTime, 0);
        //}
        //ielse f(Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y-m_speed*Time.deltaTime, 0);
        //}

        if (m_input == null) return;

        //transform.Translate(new Vector3(Input.GetAxis("Horizontal") * (m_speed*Time.deltaTime),Input.GetAxis("Vertical")*(m_speed*Time.deltaTime),0));
        transform.Translate(new Vector3(m_input.GetAxis.x *(m_speed.x * Time.deltaTime),
            m_input.GetAxis.y * (m_speed.y * Time.deltaTime), 0));
    }
}
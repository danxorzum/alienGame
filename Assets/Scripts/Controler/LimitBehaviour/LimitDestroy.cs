using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitDestroy : MonoBehaviour
{
    public GameObject m_upperLimit;
    public GameObject m_bottomLimit;

    public void Start()
    {
        m_upperLimit = GameManager.Instance.UpperLimit;
        m_bottomLimit = GameManager.Instance.BottomLimit;
    }

    private void LateUpdate()
    {
        float upperLimit = m_upperLimit.transform.position.y;
        float bottomLimit = m_bottomLimit.transform.position.y;
        float leftLimit = m_bottomLimit.transform.position.x;
        float rightLimit = m_upperLimit.transform.position.x;

        Vector3 desiredPosition = gameObject.transform.position;

        if (upperLimit < desiredPosition.y)
        {
            Destroy(gameObject);
        }
        else if (bottomLimit > desiredPosition.y)
        {
            Destroy(gameObject);
        }

        if (rightLimit < desiredPosition.x)
        {
            Destroy(gameObject);
        }
        else if (leftLimit > desiredPosition.x)
        {
            Destroy(gameObject);
        }
        // izq der

        
    }
}

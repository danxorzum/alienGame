using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRandom : MonoBehaviour
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

        float randomX = UnityEngine.Random.Range(leftLimit,rightLimit);

        if (upperLimit < desiredPosition.y)
        {
            desiredPosition = new Vector3(randomX, bottomLimit, 0);
        }
        else if (bottomLimit > desiredPosition.y)
        {
            desiredPosition = new Vector3(randomX, upperLimit, 0);
        }

        if (rightLimit < desiredPosition.x)
        {
            desiredPosition = new Vector3(leftLimit, desiredPosition.y, 0);
        }
        else if (leftLimit > desiredPosition.x)
        {
            desiredPosition = new Vector3(rightLimit, desiredPosition.y, 0);
        }
        // izq der

        gameObject.transform.position = desiredPosition;
    }
}

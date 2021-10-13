using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDetectionEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Bullet":
                float upperLimit = GameManager.Instance.transform.position.y;
                float bottomLimit = GameManager.Instance.transform.position.y;
                float leftLimit = GameManager.Instance.transform.position.x;
                float rightLimit = GameManager.Instance.transform.position.x;
                gameObject.transform.position = new Vector3(UnityEngine.Random.Range(leftLimit, 
                    rightLimit), upperLimit, 0);
                break;
        }
    }
}

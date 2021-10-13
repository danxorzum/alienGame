using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiiggerDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Enemy":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;

        }
    }
}

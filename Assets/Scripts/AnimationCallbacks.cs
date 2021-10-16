using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCallbacks : MonoBehaviour
{

    public void Die()
    {
        Destroy(transform.parent.gameObject);

    }
}

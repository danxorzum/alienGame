using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Us_Sniper : MonoBehaviour
{

    private Transform _target;
    public float rotationSpeed;

    void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    void Update()
    {
        Vector3 vectorToTarget = _target.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
    }
}

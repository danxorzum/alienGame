using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public float distance;
    public float speed;
    public float cd;

    private Transform _target;
    private EnemyGun _gun;
    private float _timeRemaind;


    void Awake()
    {
        _timeRemaind = Time.timeSinceLevelLoad;
        _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        _gun = gameObject.GetComponent<EnemyGun>();
        _gun.power = 250;
    }


    void Update()
    {

        if (Vector2.Distance(_target.position, gameObject.transform.position) > distance)
        transform.position = Vector2.MoveTowards(transform.position, _target.position,speed * Time.deltaTime);
        if (Time.timeSinceLevelLoad > _timeRemaind)
        {
            _gun.TripleShoot(10);
            _timeRemaind = Time.timeSinceLevelLoad + cd;
        }

    }
}


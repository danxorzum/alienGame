using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(EnemyGun))]
public class Razo : MonoBehaviour
{
    public float power;
    float _cd= 4;

    float _ti;
    EnemyGun _gun;
    // Start is called before the first frame update
    void Start()
    {
        _gun = gameObject.GetComponent<EnemyGun>();
        _ti = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad> _ti)
        {
            _ti = Time.timeSinceLevelLoad + _cd;
            _gun.Flower(40);
        }
    }
}

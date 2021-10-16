using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(EnemyGun))]
public class Oribter : MonoBehaviour
{
    private Transform _target;
    public float cD;
    // Start is called before the first frame update
    private EnemyGun _gun;
    private float _timeTarget;
    void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
        _gun = gameObject.GetComponent<EnemyGun>();
        _timeTarget = Time.timeSinceLevelLoad + cD;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad> _timeTarget)
        {
            _timeTarget = Time.timeSinceLevelLoad + cD;
            _gun.TripleShoot(10);
        }
        Orbi();
    }

    void Orbi()
    {
        transform.position = _target.position;
        transform.Rotate(Vector3.forward, 360/4 * Time.deltaTime);
        transform.Translate(new Vector2(-5, 0));
    }

}

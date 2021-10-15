using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(EnemyGun))]
public class Oribter : MonoBehaviour
{
    public GameObject target;
    public float cD;
    public float rotationSpeed;
    // Start is called before the first frame update
    private EnemyGun _gun;
    private float _timeTarget;
    void Awake()
    {
        _gun = gameObject.GetComponent<EnemyGun>();
        _timeTarget = Time.timeSinceLevelLoad + cD;
    }

    // Update is called once per frame
    void Update()
    {

    
        float angle = Mathf.Atan2(target.transform.position.y, target.transform.position.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(rotation, transform.rotation, rotationSpeed * Time.deltaTime);

        if (Time.timeSinceLevelLoad> _timeTarget)
        {
            _timeTarget = Time.timeSinceLevelLoad + cD;
            _gun.TripleShoot(10);
        }
    }

}

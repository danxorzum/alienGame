using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(EnemyGun))]
public class Razo : MonoBehaviour
{
    public enum BossStage
    {
        InitStage,
        MediumStage,
        HardStage
    }


    public float power;
    float _cd= 4;
    float _specialCd= 4;
    int _bulletN;

    BossStage _stage=BossStage.InitStage;
    float _ti;
    float _specialTi;
    bool _rage = false;
    Enemy _enemy;
    EnemyGun _gun;
    // Start is called before the first frame update
    void Start()
    {
        _gun = gameObject.GetComponent<EnemyGun>();
        _ti = Time.timeSinceLevelLoad;
        _specialTi = Time.timeSinceLevelLoad;
        ChangeState(BossStage.InitStage);
        _enemy = gameObject.GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 120 && _stage==BossStage.InitStage) ChangeState(BossStage.MediumStage);
        if (Time.timeSinceLevelLoad > 400 && _stage==BossStage.MediumStage) ChangeState(BossStage.HardStage);

        if(Time.timeSinceLevelLoad> _ti)
        {
            _ti = Time.timeSinceLevelLoad + _cd;
            _gun.CircularShoot(_bulletN);
        } if(Time.timeSinceLevelLoad> _specialTi)
        {
            _specialTi = Time.timeSinceLevelLoad + _specialCd;
            _gun.Flower(_bulletN);
        }if(_enemy.lives<50&& !_rage)
        {
            _rage = true;
            StartCoroutine(_gun.SpiralShoot(2));
        }
    }

    void ChangeState(BossStage newStage)
    {
        _stage = newStage;
        switch (_stage)
        {
            case BossStage.InitStage:
                _cd = 4;
                _specialCd = 8;
                _bulletN = 20;
                break;
            case BossStage.MediumStage:
                _cd = 2;
                _specialCd = 4;
                _bulletN = 30;
                break;
            case BossStage.HardStage:
                _cd = 1;
                _specialCd = 2;
                _bulletN = 40;
                break;
        }
    }
    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}

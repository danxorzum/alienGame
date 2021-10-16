using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float power;

    private GameObject _enemyBullet;

    private void Awake()
    {
        _enemyBullet = Resources.Load<GameObject>("Prefab/EnemyBullet");
    }
    public void Bean()
    {
        EnemyBullet newBul = Instantiate(_enemyBullet, transform.position,transform.rotation).GetComponent<EnemyBullet>();
        StartCoroutine(newBul.CurveShoot(250, 2));
    }
    public void CircularShoot(int EnemyBulletNumber)
    {
        float angle = 360 / EnemyBulletNumber;
        for(int i = 1; i <= EnemyBulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            EnemyBullet bullet= Instantiate(_enemyBullet, transform.position, rotation).GetComponent<EnemyBullet>();
            bullet.Shoot(power);
        }
        
    }public void Flower(int EnemyBulletNumber)
    {
        int petals = Random.Range(3, 8);
        float angle = 360 / EnemyBulletNumber;
        for(int i = 1; i <= EnemyBulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            EnemyBullet newBul= Instantiate(_enemyBullet, transform.position, rotation).GetComponent<EnemyBullet>();
            newBul.Shoot( SinFlower(angle * i,petals));
        }
        
    }

    private float SinFlower(float x, int petal=6) => 250 - 100 * Mathf.Abs( Mathf.Sin(petal * x * Mathf.PI / 360));


    public IEnumerator SpiralShoot(float duration, bool inverse=false, float delay=0)
    {
        if(delay>0) yield return new WaitForSeconds(delay);
        float lapse = duration / 60;
        for(int i = 1; i <= 60; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*6, inverse? Vector3.back:Vector3.forward);
            EnemyBullet newBul = Instantiate(_enemyBullet, transform.position, rotation).GetComponent<EnemyBullet>();
            newBul.Shoot(250);
                yield return new WaitForSeconds(lapse);
        }
        StartCoroutine(SpiralShoot(duration,!inverse,delay));
    }

    public void TripleShoot(int angleIncress)
    {
        
      
       EnemyBullet bull= Instantiate(_enemyBullet, transform.position, transform.rotation * Quaternion.Euler(0,0,-90)).GetComponent<EnemyBullet>();
        Quaternion rotation2= Quaternion.AngleAxis( -angleIncress, Vector3.forward) *Quaternion.Euler(0, 0, -90);
        EnemyBullet EnemyBullet2 = Instantiate(_enemyBullet, transform.position, transform.rotation * rotation2).GetComponent<EnemyBullet>();
        Quaternion rotation3= Quaternion.AngleAxis( angleIncress, Vector3.forward) * Quaternion.Euler(0, 0, -90);
        EnemyBullet EnemyBullet3 = Instantiate(_enemyBullet, transform.position, transform.rotation * rotation3).GetComponent<EnemyBullet>();

        bull.Shoot(power);
        EnemyBullet2.Shoot(power);
        EnemyBullet3.Shoot(power);
    }
}

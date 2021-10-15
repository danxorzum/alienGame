using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float power;
    public GameObject enemyBullet;

    private float _timeTarget;

    public void Bean()
    {
        EnemyBullet newBul = Instantiate(enemyBullet, transform.position,transform.rotation).GetComponent<EnemyBullet>();
        StartCoroutine(newBul.CurveShoot(250, 2));
    }
    public void CircularShoot(int EnemyBulletNumber)
    {
        float angle = 360 / EnemyBulletNumber;
        for(int i = 1; i <= EnemyBulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            Instantiate(enemyBullet, transform.position, rotation);
        }
        
    }public void Flower(int EnemyBulletNumber)
    {
        float angle = 360 / EnemyBulletNumber;
        for(int i = 1; i <= EnemyBulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            EnemyBullet newBul= Instantiate(enemyBullet, transform.position, rotation).GetComponent<EnemyBullet>();
            newBul.Shoot( SinFlower(angle * i,5));

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
            EnemyBullet newBul = Instantiate(enemyBullet, transform.position, rotation).GetComponent<EnemyBullet>();
            newBul.Shoot(250);
                yield return new WaitForSeconds(lapse);
        }
        StartCoroutine(SpiralShoot(duration,!inverse,delay==0?0.8f:0));
    }

    public void TripleShoot(int angleIncress)
    {

      
       EnemyBullet bull= Instantiate(enemyBullet, transform.position, transform.rotation).GetComponent<EnemyBullet>();
        Quaternion rotation2= Quaternion.AngleAxis( -angleIncress, Vector3.forward);
        EnemyBullet EnemyBullet2 = Instantiate(enemyBullet, transform.position, transform.rotation * rotation2).GetComponent<EnemyBullet>();
        Quaternion rotation3= Quaternion.AngleAxis( angleIncress, Vector3.forward);
        EnemyBullet EnemyBullet3 = Instantiate(enemyBullet, transform.position, transform.rotation * rotation3).GetComponent<EnemyBullet>();

        bull.Shoot(power);
        EnemyBullet2.Shoot(power);
        EnemyBullet3.Shoot(power);
    }
}

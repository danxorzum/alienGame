using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public float coolDown;
    public GameObject bullet;

    private float _timeTarget;
    // Start is called before the first frame update
    void Start()
    {
        _timeTarget = Time.timeSinceLevelLoad + coolDown;
           StartCoroutine(SpiralShoot(1));
           // StartCoroutine(SpiralShoot(1,false,0.8f));


    // Update is called once per frame
    }
    void Update()
    {
        if(Time.timeSinceLevelLoad> _timeTarget)
        {
            //CircularShoot(30);
            Flower(40);
            //Bean();
        _timeTarget = Time.timeSinceLevelLoad + coolDown;
        }
    }


    private void Bean()
    {
        Bullet newBul = Instantiate(bullet, transform.position,transform.rotation).GetComponent<Bullet>();
        StartCoroutine(newBul.CurveShoot(250, 2));
    }
    private void CircularShoot(int bulletNumber)
    {
        float angle = 360 / bulletNumber;
        for(int i = 1; i <= bulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            Instantiate(bullet, transform.position, rotation);
        }
        
    }private void Flower(int bulletNumber)
    {
        float angle = 360 / bulletNumber;
        for(int i = 1; i <= bulletNumber; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*angle, Vector3.forward);
            Bullet newBul= Instantiate(bullet, transform.position, rotation).GetComponent<Bullet>();
            newBul.Shoot( SinFlower(angle * i,5));

        }
        
    }

    private float SinFlower(float x, int petal=6) => 250 - 100 * Mathf.Abs( Mathf.Sin(petal * x * Mathf.PI / 360));


    private IEnumerator SpiralShoot(float duration, bool inverse=false, float delay=0)
    {
        if(delay>0) yield return new WaitForSeconds(delay);
        float lapse = duration / 60;
        for(int i = 1; i <= 60; i++)
        {

            Quaternion rotation = Quaternion.AngleAxis(i*6, inverse? Vector3.back:Vector3.forward);
            Bullet newBul = Instantiate(bullet, transform.position, rotation).GetComponent<Bullet>();
            newBul.Shoot(250);
                yield return new WaitForSeconds(lapse);
        }
        StartCoroutine(SpiralShoot(duration,!inverse,delay==0?0.8f:0));
    }
}

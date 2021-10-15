using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    protected Rigidbody2D _rb;
    protected const float _despownTime =3;
    private bool col = false;
    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        col = true;
        Destroy(gameObject);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        col = true;
        Destroy(gameObject);
    }
    public void  Shoot(float speed)
    {
        _rb.AddRelativeForce(Vector3.up * speed);
    }
    
    public IEnumerator CurveShoot(float force, float speed)
    {
        _rb.AddRelativeForce(Vector2.up * force);
        while (!col)
        {
            _rb.AddRelativeForce(Vector2.right * speed* force);
            yield return new WaitForSeconds(0.3f);
        }
    }


}

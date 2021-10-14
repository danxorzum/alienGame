using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb;
    private const float _despownTime =3;
    // Start is called before the first frame update
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Time.timeSinceLevelLoad > Time.timeSinceLevelLoad + _despownTime) Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7) Destroy(collision.gameObject);
        //Destroy(gameObject);
    }
    public void  Shoot(float speed)
    {
        _rb.AddRelativeForce(Vector3.up * speed);
    }
}

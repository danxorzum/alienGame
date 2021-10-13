using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class Larva : MonoBehaviour
{
    public float force;

    private Vector2 _direction;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    private void Awake()
    {
        
        _rb =gameObject.GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }
    void Start()
    {
        Move();
    }
    private void OnEnable()
    {
        Move();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Move()
    {
        _direction = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f)).normalized;
        _rb.AddForce(_direction * force*10);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}

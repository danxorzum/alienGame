using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class BouncingMan : MonoBehaviour
{
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
        _rb.AddRelativeForce( Random.insideUnitCircle.normalized * 500);
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("entre");
        if(collision.gameObject.layer==6)
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}

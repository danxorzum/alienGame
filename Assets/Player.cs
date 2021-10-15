using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lives;
    public float hurtsCd;

    private float _inter;
    // Start is called before the first frame update

    private void Awake()
    {
        _inter = Time.timeSinceLevelLoad;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.layer == 7)
            if (Time.timeSinceLevelLoad > _inter)
            {
                _inter = Time.timeSinceLevelLoad + hurtsCd;
                Hurt(); 
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
            if (Time.timeSinceLevelLoad > _inter)
            {
                _inter = Time.timeSinceLevelLoad + hurtsCd;
                Hurt();
            }
    }
    private void Hurt()
    {
        lives--;
        print("auch");
        if (lives <= 0) Destroy(gameObject);
    }
}

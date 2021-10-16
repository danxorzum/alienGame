using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider2D))]
public class Enemy : MonoBehaviour
{
    public int lives;
    public Animator animator;
    public string diedAnim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
            Hurt();
    }
    private void Hurt()
    {
        lives--;
        if (lives <= 0) { 
        
        animator.Play(diedAnim);
        Destroy(gameObject,0.5f);
        }
    }
}

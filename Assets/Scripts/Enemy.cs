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
        Debug.Log("sfasfaf");
        if (collision.gameObject.layer == 9)
            Hurt();
    }
    private void Hurt()
    {
        print("fsgdfg");
        lives--;
        if (lives <= 0) { 
        
        animator.Play(diedAnim);
        }
    }
    
}

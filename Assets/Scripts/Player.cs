using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int lives;
    public float hurtsCd;
    public Animator _animator;

    private float _inter;
    // Start is called before the first frame update

    private void Awake()
    {
        _inter = Time.timeSinceLevelLoad;
        _animator = GetComponentInChildren<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
            if (Time.timeSinceLevelLoad > _inter)
            {
                _inter = Time.timeSinceLevelLoad + hurtsCd;
                Hurt();
            }
    }
    private void Hurt()
    {
        _animator.Play("player_hurt");
        lives--;
        if (lives <= 0) SceneManager.LoadScene(2); ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enity : MonoBehaviour
{
    public int maxHealth = 100;
    public int Health;
    public static float speed = 0f;
    public Transform target;
    public bool FacingRight = true;
    public Animator animator;
    public bool Dead = false;
    public GameObject Hero;

    public void start()
    {
        maxHealth = Health;
        
    }


    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position,target.position , speed);
        if (speed > 0f)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }


    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void IntDamage(int attackdamage)
    {
        Health -= attackdamage;

        if (Health <= 0)
        {
            Die();
        }
    }


    public void Die()
    {
        animator.SetBool("Dead",true);
        GetComponent<CapsuleCollider2D>().enabled = false;
        this.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player.Instance.gameObject)
        {
            Player.Instance.GetDamage();
        }
    }


}

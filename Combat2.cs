using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat2 : MonoBehaviour
{
    public Animator animator;
    public Transform PointAttack;
    public float attackrange = 0.5f;
    public int attackdamage = 25;
    public LayerMask enityLayers;
    public AudioSource Hit;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack2();
            Hit.Play();
        }

    }


    void Attack2()
    {
        animator.SetTrigger("Attack");
        Collider2D[] Hitenities1 = Physics2D.OverlapCircleAll(PointAttack.position, attackrange, enityLayers);

        foreach (Collider2D enity in Hitenities1)
        {
            enity.GetComponent<EnityTrig>().IntDamage(attackdamage);

            Debug.Log("Hit");
        }
    }

    public void OnDrawGizmosSelected()
    {
        if (PointAttack == null)
            return;
        Gizmos.DrawWireSphere(PointAttack.position, attackrange);
    }
}

using UnityEngine;

public class Combat : MonoBehaviour
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
            Attack();
            Hit.Play();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] Hitenities = Physics2D.OverlapCircleAll(PointAttack.position, attackrange, enityLayers);

        foreach(Collider2D enity in Hitenities)
        {
            enity.GetComponent<Enity>().IntDamage(attackdamage);
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

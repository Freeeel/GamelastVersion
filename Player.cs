using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static float speed = 1f;
    private float HorizontalMove = 0f;
    private bool FacingRight = true;
    public static bool Death = false;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public Animator animator;
    public static float health = 3;
    public int numHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite deadHeart;
    public GameObject DeathScreen;
    public LayerMask enityLayers;
    public GameObject Medical;
    public AudioSource run;
    public AudioSource damage;


    public static Player Instance { get; private set; }


    public void Start()
    {
        health = 3;
        Death = false;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        Instance = this;
        DeathScreen.gameObject.SetActive(false);
    }

    
    public void Update()
    {
        Input.GetButton("Horizontal");
            Run();
        animator.SetFloat("HorizontalMove", Mathf.Abs(HorizontalMove));

        if (HorizontalMove < 0 && FacingRight)
        {
            Checkflip();
        }
        else if (HorizontalMove > 0 && !FacingRight)
        {
            Checkflip();
        }

        if (Death == true)
        {
            DeathScreen.SetActive(true);
        }
        else if (Death == false)
        {
            DeathScreen.SetActive(false);
        }
    }


    private void FixedUpdate()
    {
        Death = false;
        if (health > 3 )
        {
            health = 3;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = deadHeart;
            }
        }
        if (health == 0)
        {
            Death = !Death;
            Debug.Log(Death);
        }
    }



    public void Run()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 TargetVelocity = new Vector2 (HorizontalMove * 3f, rb.velocity.y);
        rb.velocity = TargetVelocity;
        run.Play();
        
    }



    public void Checkflip()
    {
        FacingRight = !FacingRight;

         Vector3 theScale = transform.localScale;
         theScale.x *= -1;
         transform.localScale = theScale;
    }


    public void GetDamage()
    {
        health -= 1;
        Debug.Log(health);
        damage.Play();
    }


  

}

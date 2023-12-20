using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHodit : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int damage = 2;

    public PlayerHealth HP;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    private void Start()
    {
        animator.SetBool("IsWepons", false);
        animator.SetBool("IsAttack", false);
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.I))
        {
            animator.SetBool("IsWepons", true);
        }
        else if (Input.GetKey(KeyCode.O)) 
        {
            animator.SetBool("IsWepons", false);
        }
        if(Input.GetKey(KeyCode.Mouse1)) 
        {
            animator.SetBool("IsAttack", true);
            animator.SetFloat("Attack", 1);
        }
        else
        {
            animator.SetBool("IsAttack", false);
            animator.SetFloat("Attack", 0);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("IsAttack", true);
            animator.SetFloat("Attack", -1);
        }



        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HP.TakeDamage(damage);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed *  Time.fixedDeltaTime);
    }
}

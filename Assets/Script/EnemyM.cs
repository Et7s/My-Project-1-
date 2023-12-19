using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyM : MonoBehaviour
{

    public float speed = 2f;
    public float Patrolling = 15f;
    public float Attacking = 2f;
    public float NormSpeed;

    public Rigidbody2D rb;
    public Transform player;
    public Animator animator;

    Vector2 movement;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        animator.SetBool("IsWalk", true);
        animator.SetBool("IsAttack", false);

        NormSpeed = speed;
    }
    private void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if(distance > Patrolling)
        {
            speed = 0;
            animator.SetBool("IsWalk", false);
            animator.SetBool("IsAttack", false);
        }
        else if(distance < Attacking) {
            speed = 0;
            animator.SetBool("IsAttack", true);
        }
        else
        {
            speed = NormSpeed;
            animator.SetBool("IsWalk", true);
            animator.SetBool("IsAttack", false);
        }

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}

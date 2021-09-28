using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour

{
    
    private Camera cam;

    public Transform firePoint;

    Animator animator;

    Vector2 MousePos;

    Vector2 movement;
    [SerializeField]
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    //private Rigidbody2D fb;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cam = Camera.main;
        rb = gameObject.GetComponent<Rigidbody2D>();
        //fb = firePoint.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        float aniSpeed = Mathf.Abs(movement.x) + Mathf.Abs(movement.y);
        animator.SetFloat("Speed", aniSpeed);
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsAttacking", true);
            //TODO: Call when attack animation is done
            animator.SetBool("IsAttacking", false);
        }
        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.fixedDeltaTime));

        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
        //fb.position = rb.position;
        //fb.rotation = angle;
        //float fbOffset = 0.64f;
        //firePoint.RotateAround(transform.position,new*fbOffset,angle);
    }

 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Shuriken")
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider2D>());
        }
    }

    // lägg till animationer så spriten tittar åt rätt håll.

    //lägg till idol/running animationer


}




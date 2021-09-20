using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour

{
    
    private Camera cam;

    public Transform firePoint;

    Vector2 MousePos;

    Vector2 movement;
    [SerializeField]
    private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Rigidbody2D fb;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        rb = gameObject.GetComponent<Rigidbody2D>();
        fb = firePoint.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        fb.rotation = angle;
        fb.position = rb.position;

    }

    // lägg till animationer så spriten tittar åt rätt håll.

    //lägg till idol/running animationer


}




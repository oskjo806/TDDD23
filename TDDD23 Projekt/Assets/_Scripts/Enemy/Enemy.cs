using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    //Might use later
    public bool canFly = true; // check för att kolla om man kan flyga över hål
    public bool isRanged = true; // check för att kolla om enemy är meele/ranged



    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float shootingRange;
    public float lineOfSite;
    public float attackForce = 0.001f;
    public GameObject attackPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float nextFireTime;
    private float turnRate = 5f;
    private float turnTime;
    Vector2 playerDir;
    Rigidbody2D rbE;
    Vector2 movementDir = new Vector2(0, 0);

    private bool mustPatrol;


    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        rbE = transform.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position,transform.position);

        //rotate the enemy in the player direction
        

        if(mustPatrol){
            patrol();
        }
        else if(distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange){
            //See player, move towards it
            MoveToPlayer();
            mustPatrol = false;
        }else if(distanceFromPlayer < lineOfSite)
        {
            RotateToPlayer();
            mustPatrol = false;
        }
        if(distanceFromPlayer <= shootingRange && nextFireTime < Time.time){
            Shoot();
            nextFireTime = Time.time + fireRate;
            mustPatrol = false;

        }
        if(distanceFromPlayer > lineOfSite)
        {
            mustPatrol = true;
        }
      
                
    }

    private void RotateToPlayer()
    {
        playerDir = (Vector2)player.position - rbE.position;
        float angle = Mathf.Atan2(playerDir.y, playerDir.x) * Mathf.Rad2Deg + 90f;
        rbE.rotation = angle;
    }

    private void MoveToPlayer()
    {
        playerDir = (Vector2)player.position - rbE.position;
        float angle = Mathf.Atan2(playerDir.y, playerDir.x) * Mathf.Rad2Deg + 90f;
        rbE.rotation = angle;
        transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
    }


    void Shoot()
    {
        GameObject Attack = Instantiate(attackPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rbA = Attack.GetComponent<Rigidbody2D>();
        //Vector2 fireDir = (playerDir).normalized * attackForce;
        //rbA.velocity = fireDir;
        rbA.AddForce(firePoint.up * attackForce, ForceMode2D.Impulse);
    }

    private void patrol(){
        //Decide movement direction every x sec
        if (turnTime < Time.time)
        {
            movementDir = Random.insideUnitCircle.normalized;
            turnTime = Time.time + turnRate;
        }
        Debug.Log(movementDir);
        float angle = Mathf.Atan2(movementDir.y, movementDir.x) * Mathf.Rad2Deg + 90f;
        rbE.rotation = angle;
        rbE.MovePosition(rbE.position + (movementDir.normalized * speed * Time.fixedDeltaTime));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Walls")
        {
            movementDir = -movementDir;
        }
    }
}

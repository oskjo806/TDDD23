using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public float shootingRange;
    public float lineOfSite;
    public float attackForce;
    public float attackRotation;
    public int attackCD;
    public GameObject attackPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public float nextFireTime;



    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position,transform.position);
        if(distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange){
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }else if(distanceFromPlayer <= shootingRange && nextFireTime < Time.time){
            Shoot();
            nextFireTime = Time.time + fireRate;

        }
    }
    void Shoot()
    {
        Debug.Log(transform.position);
        GameObject Attack = Instantiate(attackPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = Attack.GetComponent<Rigidbody2D>();
        //rb.AddForce(firePoint.up * attackForce, ForceMode2D.Impulse);
        Vector2 moveDir = (Attack.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(Attack, 2);
    }

    private void onDrawGizmosSelected(){
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}

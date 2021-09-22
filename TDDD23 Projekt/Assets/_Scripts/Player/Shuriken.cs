using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    //public GameObject hitEffect; //Effect d� shuriken tr�ffar n�t

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider2D>());  
        }
        else
        {
            //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            //Destroy(effect, 5f);
            Destroy(gameObject);
        }
    }
}

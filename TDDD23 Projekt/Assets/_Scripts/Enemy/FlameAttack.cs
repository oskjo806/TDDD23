using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAttack : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collider: " + collision.collider.name + " tag: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "FlameEnemy")
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

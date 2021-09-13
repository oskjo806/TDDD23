using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            target = other.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
        }
    }
    private void Update()
    {

    }
    public void MakeMove()
    {
        Debug.Log("Make Move: "+ transform.name);
        transform.position += Vector3.left;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class Holes : MonoBehaviour
{
    TilemapCollider2D tmCol;
    Collider2D collisionTarget = null;
    Rigidbody2D targetRB = null;
    void Start()
    {
        tmCol = GetComponent<TilemapCollider2D>();
    }
    private void FixedUpdate()
    {
        if(collisionTarget != null)
        {
            if (tmCol.OverlapPoint(collisionTarget.transform.position))
            {
                if(collisionTarget.tag == "Player")
                {
                    targetRB.GetComponent<PlayerController>().enabled = false;
                    targetRB.MoveRotation(targetRB.rotation + (100.0f * Time.fixedDeltaTime));

                    StartCoroutine(passiveMe(3));
                    IEnumerator passiveMe(int secs)
                    {
                        yield return new WaitForSeconds(secs);
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisionTarget = collision;
        targetRB = collisionTarget.attachedRigidbody;
    }
    private void OnTriggerExit(Collider other)
    {
        collisionTarget = null;
        targetRB = null;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenAttack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject ShurikenPrefab;

    public float ShurikenForce = 20f;
    public float ShurikenRotation = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject Shuriken = Instantiate(ShurikenPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = Shuriken.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * ShurikenForce, ForceMode2D.Impulse);
        rb.AddTorque(ShurikenRotation, ForceMode2D.Force);
    }
}

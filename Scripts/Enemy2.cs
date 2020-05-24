using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int health = 100;


    public GameObject EnemyBullet;

    float fireRate;
    float nextFire;
    


    public void TakeDamage(int damage)
    {

        health -= damage;
        if (health <= 0)
        {
            Die();
        }

    }


    void Die()
    {
        Destroy(gameObject);
        Debug.Log("YOU WIN YOU PIECE OF AS");
    }
    // Start is called before the first frame update
    void Start()
    {


        fireRate = 1f;
        nextFire = Time.time;
    }


    // Update is called once per frame
    void Update()

    {
        transform.position += new Vector3(0.1f * Mathf.Sin(1f * Time.time), 0);


        CheckFire();
    }
    void CheckFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(EnemyBullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    
    public GameObject EnemyBullet;

    float fireRate;
    float nextFire;
    float speedOfEnemy = 1.1f;
    

    public void TakeDamage (int damage)
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
        transform.position = new Vector3(Mathf.Cos(5f * Time.time), 3.57f, 0) * speedOfEnemy;


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

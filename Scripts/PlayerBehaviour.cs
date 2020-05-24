using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public int health = 100;
    public float speed = 5f;
    public Transform firePoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeADamage (int Edamage)
    {
        health -= Edamage;
        if(health <= 0)
        {
            WeDie();
        }

    }
 
    void WeDie()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        float movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float movement2= Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(0, movement2, 0);
        transform.Translate(movement, 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }

       
    }
}

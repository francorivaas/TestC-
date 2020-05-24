using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float Speed = 7f;
    public Rigidbody2D rb;
    

    PlayerBehaviour target;
    new Vector2 Mov;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D> ();
        target = GameObject.FindObjectOfType<PlayerBehaviour>();
        Mov = (target.transform.position - transform.position).normalized * Speed;
        rb.velocity = new Vector2(Mov.x, Mov.y);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       PlayerBehaviour player = collision.GetComponent<PlayerBehaviour>();
        if (player != null) 
        {
            player.TakeADamage(5);
            Destroy(gameObject);
        }
       
    }


}

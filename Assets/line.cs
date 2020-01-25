using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public float jumpforce = 10f;
    void OnCollisionEnter2D(Collision2D col)
    {
        Rigidbody2D rb = col.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 vel = rb.velocity;
            vel.y = jumpforce;
            rb.velocity = vel;

        }
    }
}
    
    

        
		

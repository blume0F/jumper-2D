using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public GameObject player1;
    Rigidbody2D rb;
    public float movespeed = 10f;
    public float Mov;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        Mov = Input.GetAxis("Horizontal") * movespeed; ;

    }
    void FixedUpdate()
    {
        {
            Vector2 vel = rb.velocity;
            vel.x = Mov;
            rb.velocity = vel;

        }
    }
     public  void gameover()
    {
            if (player1.transform.position.y < transform.position.y)
            {
                restart();
            }
        }
      public  void restart()
            {
            SceneManager.LoadScene("SampleScene");
        }
}


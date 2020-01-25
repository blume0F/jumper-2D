using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform player;
    void LateUpdate()
    {
        if (player.position.y > transform.position.y)
        {
            Vector3 newpos = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = newpos;
        }

    }
}
 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    public GameObject linePrefab;
    public float miny = 3f;
    public float maxy = 4.7f;
    public float nooflines = 200f;
    public float xvalue =4.5f;
    void Start()
    {
        Vector3 spawn = new Vector3();
        for (int i = 1; i <= nooflines; i++)
        {
            spawn.y+=Random.Range(miny, maxy);
            spawn.x = Random.Range(-xvalue, xvalue);
            Instantiate(linePrefab, spawn, Quaternion.identity);
        }
    }
}

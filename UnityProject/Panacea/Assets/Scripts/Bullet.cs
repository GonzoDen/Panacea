using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 5;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.up * Time.deltaTime * speed;
    }
   
}
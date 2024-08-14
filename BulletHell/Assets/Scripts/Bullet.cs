using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private Rigidbody2D bulletRb;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();

        bulletRb.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

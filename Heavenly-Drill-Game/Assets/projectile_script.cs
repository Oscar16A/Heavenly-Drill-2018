using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour {
    public float speed = 20f;
    public float lifetime = 2.0f;
    public Rigidbody2D rb;


    private void Start()
    {
        rb.velocity = transform.up * speed;
    }


    public void Update()
    {
        Awake();

    }

    private void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}

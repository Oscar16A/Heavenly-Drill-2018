using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour {
    public float speed = 20f;


    private void Start()
    {
        rb.velocity = transform.up * speed;
    }


    public void Update()
    {
        

    }
}

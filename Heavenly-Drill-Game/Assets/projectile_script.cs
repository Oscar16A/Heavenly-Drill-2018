using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour {
    public float upspeed = 7f;
    public float lifetime = 3.0f;
    public GameObject pickup;
    public GameObject explosion;

    private void Start()
    {
    }


    public void Update()
    {
        transform.Translate(Vector3.up * upspeed * Time.deltaTime);
        Awake();
    }

    private void Awake()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fuelpickup"))
        {
            if (fuel.f < 90)
            {
                fuel.f += 10;
            }
            else
            {
                fuel.f = 100;
            }
            Instantiate(pickup, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("rock"))
        {
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
    }
}

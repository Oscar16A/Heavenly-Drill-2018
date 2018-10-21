using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour {
    public float upspeed = 7f;


    private void Start()
    {
    }


    public void Update()
    {
        transform.Translate(Vector3.up * upspeed * Time.deltaTime);
    }

    private void Awake()
    {
        Destroy(gameObject, lifetime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour {
    public float upspeed = 7f;
<<<<<<< HEAD
    public float lifetime = 3;
=======
    public float lifetime = 3.0f;

>>>>>>> 75e99a6c2639e08ea1839750a599c488236cb510

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
}

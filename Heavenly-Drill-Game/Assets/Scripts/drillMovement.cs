using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drillMovement : MonoBehaviour {

    public float speed = 30f;
    public static bool dead;
    private bool componentAdded;
    public GameObject pickup;
    public GameObject explosion;

	// Use this for initialization
	void Start () {
        dead = false;
        componentAdded = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(!dead)
        {
            transform.Translate(-transform.rotation.z * speed * Time.deltaTime, 0, 0, Space.World);
        }
        else if(!componentAdded)
        {
            gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<AudioSource>().enabled = false;
            gameObject.AddComponent<goDown>();
            componentAdded = true;
        }
        if(dead)
        {
            Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + .5f, transform.position.z), transform.rotation);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("fuelpickup"))
        {
            if(fuel.f < 92)
            {
                fuel.f += 8;
            }
            else
            {
                fuel.f = 100;
            }
            Instantiate(pickup, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
        else if (playerController.iBoost && collision.gameObject.CompareTag("rock"))
        {
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);
        }
        else
        {
            if (!dead)
            {
                Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + .5f, transform.position.z), transform.rotation);
                //gameObject.GetComponent<SpriteRenderer>().enabled = false;
                death();
                Destroy(gameObject);
            }
        }
    }

    public void death()
    {
        dead = true;
    }
}

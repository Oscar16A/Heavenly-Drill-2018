using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drillMovement : MonoBehaviour {

    public float speed = 30f;
    public static bool dead;
    private bool componentAdded;

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
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        death();
    }

    public void death()
    {
        dead = true;
    }
}

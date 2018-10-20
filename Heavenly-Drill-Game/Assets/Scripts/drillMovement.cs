using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drillMovement : MonoBehaviour {

    public float speed = .8f;
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
            transform.Translate(-transform.rotation.z * speed, 0, 0, Space.World);
        }
        else if(!componentAdded)
        {
            gameObject.AddComponent<goDown>();
            componentAdded = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("hi");
        death();
    }

    void death()
    {
        dead = true;
    }
}

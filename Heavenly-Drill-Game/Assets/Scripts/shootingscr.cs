using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscr : MonoBehaviour {

    public GameObject projec;
    private float armed;

	// Use this for initialization
	void Start () {
        armed = 0f;
        gameObject.GetComponent<AudioSource>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space"))
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
            if (armed > 2f && !drillMovement.dead)
            {
                Instantiate(projec, transform.position, transform.rotation);
            }
            armed = 0f;
        }
        if (Input.GetKey("space") && !playerController.boostcooldown)
        {
            armed += Time.deltaTime;
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        if(drillMovement.dead)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
    }
}

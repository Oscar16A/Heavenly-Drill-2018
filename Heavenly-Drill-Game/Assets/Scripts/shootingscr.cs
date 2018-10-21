using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscr : MonoBehaviour {

    public GameObject projec;
    private float armed;

	// Use this for initialization
	void Start () {
        armed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("space") && armed > 2f)
        {
            Instantiate(projec, transform.position, transform.rotation);
            armed = 0f;
        }
        if (Input.GetKey("space") && !playerController.boostcooldown)
        {
            armed += Time.deltaTime;
        }
    }
}

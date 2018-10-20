using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float turnspeed = .6f;
    public float turnbackmodifier = .8f;
    public float turnlimit = .15f;
    bool isTurning;
    public float lBoundary = -5f;
    public float rBoundary = 5f;

	// Use this for initialization
	void Start () {
        isTurning = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!drillMovement.dead)
        {
            if (Input.GetKey("left") && transform.rotation.z <= turnlimit && transform.position.x > lBoundary)
            {
                transform.Rotate(0, 0, turnspeed);
                isTurning = true;
            }

            if (Input.GetKey("right") && transform.rotation.z >= -turnlimit && transform.position.x < rBoundary)
            {
                transform.Rotate(0, 0, -turnspeed);
                isTurning = true;
            }
            if (transform.position.x <= lBoundary && transform.rotation.z > 0f)
            {
                transform.Rotate(0, 0, -turnspeed * 1.25f);
            }
            else if (transform.position.x >= rBoundary && transform.rotation.z < 0f)
            {
                transform.Rotate(0, 0, turnspeed * 1.25f);
            }
            else if (transform.rotation.z < .005f && transform.rotation.z > -.005f && !isTurning)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            else if (transform.rotation.z < 0f && !isTurning)
            {
                transform.Rotate(0, 0, turnspeed * turnbackmodifier);
            }
            else if (transform.rotation.z > 0f && !isTurning)
            {
                transform.Rotate(0, 0, -turnspeed * turnbackmodifier);
            }
            isTurning = false;
        }
	}
}

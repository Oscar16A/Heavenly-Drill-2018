using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float turnspeed = 50f;
    public float boostspeed = .7f;
    public float turnbackmodifier = .8f;
    public float turnlimit = .15f;
    bool isTurning;
    public float lBoundary = -5f;
    public float rBoundary = 5f;
    public float bBoundary = -5.2f;
    public float speed = 10f;

    public GameObject projectilePrefab;
    public Transform firepoint;

    private float spaceTime;
    public static bool boostcooldown;



    // Use this for initialization
    void Start () {
        isTurning = false;
        spaceTime = 0f;
        boostcooldown = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!drillMovement.dead)
        {
            if (Input.GetKeyDown("space"))
            {
                gameObject.GetComponent<Animator>().speed = 2f;
            }
            if (Input.GetKeyUp("space"))
            {
                gameObject.GetComponent<Animator>().speed = 1f;
                boostcooldown = true;
            }
            if (Input.GetKey("space") && !boostcooldown)
            {
                transform.Translate(0, boostspeed *2f * Time.deltaTime, 0, Space.World);
            }
            else if (transform.position.y >= bBoundary)
            {
                transform.Translate(0, -boostspeed * Time.deltaTime, 0, Space.World);
            }
            else
            {
                boostcooldown = false;
            }
            if (Input.GetKey("left") && transform.rotation.z <= turnlimit && transform.position.x > lBoundary)
            {
                transform.Rotate(0, 0, turnspeed * Time.deltaTime);
                isTurning = true;
            }
            if (Input.GetKey("right") && transform.rotation.z >= -turnlimit && transform.position.x < rBoundary)
            {
                transform.Rotate(0, 0, -turnspeed * Time.deltaTime);
                isTurning = true;
            }
            if (transform.position.x <= lBoundary && transform.rotation.z > 0f)
            {
                transform.Rotate(0, 0, -turnspeed * 1.25f * Time.deltaTime);
            }
            else if (transform.position.x >= rBoundary && transform.rotation.z < 0f)
            {
                transform.Rotate(0, 0, turnspeed * 1.25f * Time.deltaTime);
            }
            else if (transform.rotation.z < .005f && transform.rotation.z > -.005f && !isTurning)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            else if (transform.rotation.z < 0f && !isTurning)
            {
                transform.Rotate(0, 0, turnspeed * turnbackmodifier * Time.deltaTime);
            }
            else if (transform.rotation.z > 0f && !isTurning)
            {
                transform.Rotate(0, 0, -turnspeed * turnbackmodifier * Time.deltaTime);
            }
            isTurning = false;

            if (transform.rotation.z < .005f && transform.rotation.z > -.005f && !isTurning)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
	}

}

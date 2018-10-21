using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_background : MonoBehaviour {
    public Vector3 default_position;
    public int resetYPosition;

    public float speed;
    private float boostRatio;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        boostRatio = boost.boostRatio;
        transform.Translate(Vector3.down*speed*boostRatio*Time.deltaTime, Space.World);
        if (transform.position[1] <= resetYPosition)
        {
            transform.position = default_position;
        }

	}
}

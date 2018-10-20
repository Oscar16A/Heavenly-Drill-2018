using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_background : MonoBehaviour {
    public Vector3 default_position = new Vector3(0, 0, -5);
    public Vector3 reset_location = new Vector3(0, 0, -5);

    public float speed = -.2f;
    public float boost_ratio = 1f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, speed*boost_ratio, 0);
        if (transform.position[1] <= reset_location[1]){
            transform.position = default_position;
        }

	}
}

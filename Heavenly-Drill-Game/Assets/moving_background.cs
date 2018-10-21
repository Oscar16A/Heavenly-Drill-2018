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
        transform.Translate(0, speed*boostRatio, 0);
        if (transform.position[1] <= resetYPosition)
        {
            transform.position = default_position;
        }

	}
}

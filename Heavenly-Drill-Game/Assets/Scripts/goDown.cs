﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goDown : MonoBehaviour {

    private float downspeed = .03f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * downspeed, Space.World);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour {

    public float scrollSpeed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * scrollSpeed, Space.World);

    }
}

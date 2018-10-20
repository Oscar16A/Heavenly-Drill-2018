using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drillMovement : MonoBehaviour {

    float speed = .8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-transform.rotation.z*speed, 0, 0, Space.World);
    }
}

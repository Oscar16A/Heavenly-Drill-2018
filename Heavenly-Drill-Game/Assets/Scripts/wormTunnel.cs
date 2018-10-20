using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormTunnel : MonoBehaviour {

    public GameObject worms;

	// Use this for initialization
	void Start () {
        Instantiate(worms, new Vector3(transform.position.x, transform.position.y, transform.position.z-1f), transform.rotation);
    }
}

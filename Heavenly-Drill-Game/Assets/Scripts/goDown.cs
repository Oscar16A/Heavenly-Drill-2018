using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goDown : MonoBehaviour {

    public float downSpeed;
    private float boostRatio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        boostRatio = boost.boostRatio;
        transform.Translate(Vector3.down * downSpeed * boostRatio, Space.World);

    }
}

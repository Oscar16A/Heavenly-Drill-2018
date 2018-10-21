using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploScript : MonoBehaviour {

    public float explolength = .4f;
    private float timer;

	// Use this for initialization
	void Start () {
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= explolength)
        {
            Destroy(this.gameObject);
        }
	}
}

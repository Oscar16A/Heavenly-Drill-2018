using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fastSpawnTest : MonoBehaviour {

    public GameObject expla;
    private float hi = 1f;
    private float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= hi)
        {
            Instantiate(expla, transform.position, transform.rotation);
            timer = 0f;
        }
    }
}

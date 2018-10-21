using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuel : MonoBehaviour {

    public float fRate = .3f;
    private int f = 100;
    private float timeC;

	// Use this for initialization
	void Start () {
        timeC = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timeC += Time.deltaTime;
        if(timeC > fRate && f > 0)
        {
            f -= 1;
            timeC = 0f;
            print(f);
        }
        if(f <= 0)
        {
            GetComponent<drillMovement>().death();
        }
	}
}

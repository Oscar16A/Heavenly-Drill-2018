using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_item : MonoBehaviour {

    private Random rnd = new Random();
    private Vector3 initPosition;
    public float speed;
    public float boostRatio;
    public int despawnYPosition;

	// Use this for initialization
	void Start ()
    {


    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0,speed*boostRatio,0);
        if (transform.position[1] <= despawnYPosition)
        {
            Destroy(gameObject);
        }


    }
}

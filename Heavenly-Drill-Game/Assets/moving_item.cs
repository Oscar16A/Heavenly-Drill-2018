using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_item : MonoBehaviour {

    public float speed;
    private float boostRatio;
    public int despawnYPosition = -10;

	// Use this for initialization
	void Start ()
    {


    }
	
	// Update is called once per frame
	void Update ()
    {
        boostRatio = boost.boostRatio;
        transform.Translate(Vector3.down * speed * boostRatio * Time.deltaTime, Space.World);
        if (transform.position[1] <= despawnYPosition)
        {
            Destroy(gameObject);
        }


    }
}

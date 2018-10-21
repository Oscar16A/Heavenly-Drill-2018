using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boost : MonoBehaviour {

    public static float boostRatio;
    public float boostAmount;

	// Use this for initialization
	void Start (){
        boostRatio = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (!drillMovement.dead)
        {
            if (Input.GetKey("space"))
            {
                boostRatio = boostAmount;

            }
            else
            {
                boostRatio = 1f;
            }
        }
        else
        {
            boostRatio = 1f;
        }
    }
}

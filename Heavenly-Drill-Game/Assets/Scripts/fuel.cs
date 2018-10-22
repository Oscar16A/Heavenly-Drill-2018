using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class fuel : MonoBehaviour {

    public float fRate = .3f;
    public float boostrate = 3f;
    public static int f = 100;
    private float timeC;
    public Slider slider;

    // Use this for initialization
    void Start () {
        timeC = 0f;
        slider.value = 1.0f;
        f = 100;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("space") && !playerController.boostcooldown)
        {
            timeC += Time.deltaTime*boostrate;
        }
        else
        {
            timeC += Time.deltaTime;
        }
        if(timeC > fRate && f > 0)
        {
            f -= 1;
            timeC = 0f;
            slider.value = (float)(f / 100.0);

        }
        if (f <= 0)
        {
            GetComponent<drillMovement>().death();
        }
	}
}

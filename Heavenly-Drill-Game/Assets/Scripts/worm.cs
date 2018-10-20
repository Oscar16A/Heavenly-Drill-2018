using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worm : MonoBehaviour
{

    public float wormspeed = .1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * wormspeed);

    }
}

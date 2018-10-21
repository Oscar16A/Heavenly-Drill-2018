using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//For when Worm Spawns on LEFT side
public class wormBehavior : MonoBehaviour {

    public Animator animator;
    public bool isAttacking;
    public bool primed;
    public Vector3 initialPosition;

    public float primedXDistance;
    public float attackXDistance;

    public float primedRate;
    public float attackRate;


    public float waitTimePrimed;
    public float waitTimeAttack;

	// Use this for initialization
	void Start () {
        primed = false;
        isAttacking = false;
        StartCoroutine(executeAfterTime());
        StartCoroutine(executeAfterTime2());
        transform.position = initialPosition;

    }

    // Update is called once per frame
    void Update () {
        if (primed)
        {
            if (transform.position.x <= primedXDistance)
            {
                transform.Translate(new Vector3 (primedRate,0,0) *Time.deltaTime);
            }

        }
        if (isAttacking)
        {
            if (transform.position.x <= attackXDistance)
            {
                transform.Translate(new Vector3(attackRate, 0, 0) * Time.deltaTime);
            }

        }
    }

    // Executes after set amount of time (appears)
    IEnumerator executeAfterTime()
    {
        yield return new WaitForSeconds(waitTimePrimed);
        primed = true;
    }
    // Executes after set amount of time (aattacks)
    IEnumerator executeAfterTime2()
    {
        yield return new WaitForSeconds(waitTimeAttack);
        isAttacking = true;
        animator.SetBool("attacking", true);
    }
}

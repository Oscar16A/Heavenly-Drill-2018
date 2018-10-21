using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValuesPosition;
    public float spawnValuesRotation;
    public float spawnWait;
    public float spawnMostWeight;
    public float spawnLeastWeight;
    public int startWait;
    public bool stop;

    private int randEnemy;



	// Use this for initialization
	void Start ()
    {
        StartCoroutine(waitSpawner());


	}
	
	// Update is called once per frame
	void Update ()
    {
        spawnWait = Random.Range(spawnLeastWeight, spawnMostWeight);

	}


    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0, enemies.Length);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValuesPosition.x, spawnValuesPosition.x), 0, 0);
            Vector3 spawnRotation = new Vector3(0, 0, Random.Range(-spawnValuesRotation, spawnValuesRotation));

            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), 
                Quaternion.Euler(spawnRotation));

            yield return new WaitForSeconds(spawnWait);



        }


    }
}

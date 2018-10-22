using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReloadScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("protoTypeScene");
        }
    }
}

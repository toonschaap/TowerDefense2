using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    void Update()
    {

    }

// Use this for initialization
void OnCollisionEnter(Collision collision) { 
		if (collision.gameObject.tag == "bullet"){
            Destroy(gameObject);
            Debug.Log("Enemy dead");
        }
	}
}
	
	// Update is called once per frame


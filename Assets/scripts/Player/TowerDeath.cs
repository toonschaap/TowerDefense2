using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDeath : MonoBehaviour
{
    void Update()
    {

    }

    // Use this for initialization
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            Debug.Log("tower dead");
        }
    }
}

// Update is called once per frame


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Use this for initialization

     void Awake(){
        Debug.Log("Awake");
        }

	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("fire");
            Fire();
            
        }

    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.right * 10;

        }
   
}


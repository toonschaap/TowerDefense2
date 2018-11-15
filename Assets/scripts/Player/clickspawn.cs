using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class clickspawn : MonoBehaviour {
	public GameObject objectToSpawn;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
            Vector3 spawnPosition = new Vector3(1,1);
            //GameObject.FindGameObjectWithTag(tag: "Grid")
            spawnPosition.z = 0.0f;
			GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
		}
	}
}
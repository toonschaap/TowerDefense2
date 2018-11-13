﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class clickspawn : MonoBehaviour {
	public GameObject objectToSpawn;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			spawnPosition.z = 0.0f;
			GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
		}
	}
}
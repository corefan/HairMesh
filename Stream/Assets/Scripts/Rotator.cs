﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public Vector3 speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localRotation *= Quaternion.Euler(Time.deltaTime * speed);
	}
}

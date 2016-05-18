﻿using UnityEngine;
using System.Collections;

public class playerr : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate (Vector3.up, - turnSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
	}
}
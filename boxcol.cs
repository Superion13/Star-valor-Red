﻿using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class boxcol : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Lplayer")
			Application.LoadLevel("Space2");
	}
}
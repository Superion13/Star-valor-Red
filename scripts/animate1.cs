using UnityEngine;
using System.Collections;

public class animate1 : MonoBehaviour {
	public Animation anim;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			anim ["walktest"].enabled = true;
		}
	}
}
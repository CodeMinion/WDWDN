﻿using UnityEngine;
using System.Collections;

public class SpinnerBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(new Vector3(-0.5f,0,-0.5f));
	}
}

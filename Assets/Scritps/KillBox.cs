﻿using UnityEngine;
using System.Collections;

public class KillBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.tag == "Player")
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}

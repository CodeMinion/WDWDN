using UnityEngine;
using System.Collections;

public class R : MonoBehaviour {

	public float angles = 20;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			this.transform.parent.Rotate (0, 0, angles * Time.deltaTime);
	}
}

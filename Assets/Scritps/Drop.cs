using UnityEngine;
using System.Collections;

public class Drop : MonoBehaviour {

	public float dropSpeed =  5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.parent.Translate(0,dropSpeed*Time.deltaTime, 0);
	}
}

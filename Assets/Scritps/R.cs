using UnityEngine;
using System.Collections;

public class R : MonoBehaviour {

	public float angles = 40;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if ((int) this.transform.parent.rotation.eulerAngles.z != 0) 
			this.transform.parent.Rotate (0, 0, angles * Time.deltaTime);
		else
			this.transform.parent.rotation = Quaternion.Euler(new Vector3 (0, 0, 0));
	}
}

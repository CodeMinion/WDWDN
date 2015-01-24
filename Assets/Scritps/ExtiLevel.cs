using UnityEngine;
using System.Collections;

public class ExtiLevel : MonoBehaviour {

	public string NextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log (col.gameObject.tag);

		if(col.gameObject.tag == "Player")
		{
			Application.LoadLevel(NextLevel);
		}
	}
}

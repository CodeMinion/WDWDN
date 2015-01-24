using UnityEngine;
using System.Collections;

public class BadSwitch : MonoBehaviour {

	public GameObject toDetonate;
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
			if(toDetonate != null)
			{
				toDetonate.SetActive(false);

			}
		}
	}
}

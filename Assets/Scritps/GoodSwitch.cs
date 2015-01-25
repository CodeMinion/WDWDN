using UnityEngine;
using System.Collections;

public class GoodSwitch : MonoBehaviour {

	public GameObject toActivate;
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
			if(toActivate != null)
			{
				toActivate.SetActive(true);

				gameObject.SetActive(false);
			}
		}
	}
}

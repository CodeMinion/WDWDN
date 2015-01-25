using UnityEngine;
using System.Collections;

public class PlayOnAquire : MonoBehaviour {

	private AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			source = col.gameObject.GetComponent<AudioSource>();
			if(source != null )
			{
				source.PlayOneShot(source.clip);
				Debug.Log("Playing SFX");
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Player")
		{
			source = col.gameObject.GetComponent<AudioSource>();
			if(source != null )
			{
				source.PlayOneShot(source.clip);
				Debug.Log("Playing SFX");
			}
		}
	}
}

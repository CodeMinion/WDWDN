using UnityEngine;
using System.Collections;

public class PlayOnAquire : MonoBehaviour {

	private AudioSource clip;
	// Use this for initialization
	void Start () {
		clip = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			if(clip != null && !clip.isPlaying)
			{
				clip.Play();
			}
		}
	}
}

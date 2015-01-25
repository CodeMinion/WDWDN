using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public string FirstScene;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.transform.Rotate(new Vector3(-0.5f,0,-0.5f));

		if(Input.GetKey(KeyCode.Space) || Input.GetButtonDown("Jump"))
		{
			Application.LoadLevel(FirstScene);
		}
	}
}

using UnityEngine;
using System.Collections;

public class WallWalkerManager : MonoBehaviour 
{
	private CharacterController player;
	private int TILT_AMOUNT = 35;
	private Transform head;

	void OnEnable() 
	{
		enableWallWalk();
	}
	
	void Awake()
	{
		player = GameObject.Find("OVRPlayerController").GetComponent<CharacterController>(); 
		head = GameObject.Find("OVRCameraRig").transform;
	}

	void Update()
	{
		// For a trap.
		if(!player.isGrounded)
			Physics.gravity = new Vector3(0, -9.8F, 0);
	}

	public void detonate()
	{
		Physics.gravity = new Vector3(0, -9.8F, 0);		
		head.Rotate(0,0,TILT_AMOUNT * -1);
	}

	private void enableWallWalk()
	{
		Physics.gravity = new Vector3(-9.8F, 0, 0);
		head.Rotate(0,0,TILT_AMOUNT);
	}
}

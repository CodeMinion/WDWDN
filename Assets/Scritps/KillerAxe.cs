using UnityEngine;
using System.Collections;

public class KillerAxe : MonoBehaviour 
{
	private float angles = 20;

	private const int LIMIT = 90;

	bool delayedBool = false;

	private Transform myTransform;

	void Awake()
	{
		myTransform = transform;
	}
	
	void Update() 
	{
		myTransform.Rotate(0, 0, angles * Time.deltaTime);

		if(myTransform.rotation.eulerAngles.z >= LIMIT && !delayedBool)
		{
			myTransform.Rotate(0, 180, 0);
			
			setDelayedBool(false);
		}
	}

	/// <summary>
	/// Sets my boolean to a value but with a delay.
	/// </summary>
	/// <param name="b">If set to <c>true</c> b.</param>
	private void setDelayedBool(bool b)
	{
		StartCoroutine("setMyBool", b);
	}
	
	private IEnumerator setMyBool(bool b)
	{
		delayedBool = !b;
	
		yield return new WaitForSeconds(5f);
	
		delayedBool = b;
	}
}

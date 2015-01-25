using UnityEngine;
using System.Collections;

public class KillerTurret : MonoBehaviour {

	public float minAngle = 45f;
	public float maxAngle = 0f;
	public float deltaPerSecond =100f;

	public GameObject instantiate;
	public GameObject instantiateTarget;
		
	// Use this for initialization
	void Start () {
		maxAngle = 360f - minAngle;
		Time.timeScale = 0.4f;
	}

	// Update is called once per frame
	void Update () {
		if ((int)Time.timeSinceLevelLoad % 2 == 0) 
		{
			GameObject temp = (GameObject) GameObject.Instantiate(instantiate, instantiateTarget.transform.position, instantiate.transform.rotation);
			Destroy(temp, 20f);
		}

		if (deltaPerSecond > 0 && 
			this.transform.parent.localRotation.eulerAngles.y < 180 &&
		    this.transform.parent.localRotation.eulerAngles.y > minAngle)
		{
			deltaPerSecond = -deltaPerSecond;
			Debug.Log ("Switch");
		}

		if (deltaPerSecond < 0 && 
		    this.transform.parent.localRotation.eulerAngles.y > 180 &&
		    this.transform.parent.localRotation.eulerAngles.y < maxAngle)
		{
			deltaPerSecond = -deltaPerSecond;
			Debug.Log ("Switch");
		}

		this.transform.parent.Rotate(0,deltaPerSecond * Time.deltaTime, 0);
	}
}

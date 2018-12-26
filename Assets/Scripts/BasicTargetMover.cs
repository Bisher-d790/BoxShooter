using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	public bool doSpin = true;
	public bool doMotion = true;
	// Update is called once per frame
	void Update () {

		// rotates gameObject around y axis
		if(doSpin)
		gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);

		// moves gameObject up and down
		if(doMotion)
		gameObject.transform.Translate (Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);

	}
}

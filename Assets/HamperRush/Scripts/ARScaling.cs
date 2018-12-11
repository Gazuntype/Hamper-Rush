using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScaling : MonoBehaviour {
	public float scale;
	public Transform ARCamera;

	// Use this for initialization
	void Start () {
		MoveCameraAway();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MoveCameraAway()
	{
		transform.localScale = transform.localScale * scale;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HamperMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo(gameObject, (Camera.main.transform.forward * 5), 10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

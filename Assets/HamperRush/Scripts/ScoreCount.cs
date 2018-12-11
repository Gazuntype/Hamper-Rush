using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	Text textScore;
	public static int text_Score = 0;

	// Use this for initialization
	void Start () {
		textScore = GameObject.Find("Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Hamper"))
		{
			Debug.Log("hamper entered");
			text_Score = text_Score + 1;
			textScore.text = "Count: " + text_Score.ToString ();

		}

	}
}

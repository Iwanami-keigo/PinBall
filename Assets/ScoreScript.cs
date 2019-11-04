using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	private int Score = 0;

	private GameObject scoreText;

	void OnCollisionEnter(Collision other){

		if (other.gameObject.tag == "SmallStarTag") {
			this.Score += 5;
		} else if (other.gameObject.tag == "LargeStarTag") {
			this.Score += 20;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			this.Score += 10;
		} else if (other.gameObject.tag == "LargeCloudTag") {
			this.Score += 30;
		}
	}



		

	// Use this for initialization
	void Start () {
		this.scoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		this.scoreText.GetComponent<Text> ().text = "Score." + Score;
		
	}



}

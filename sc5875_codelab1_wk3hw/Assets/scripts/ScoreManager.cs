using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	private const int highScore = 10;
	private int score;

	public int Score {
		get{
			return score;
		}
		set{
			score = value;
			if (score > highScore) {
				score = highScore;
			}
		}
	}

	void Start()
	{
		score = 0;
		Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Score);
	}

	/*
	public int getScore()
	{
		return Score;
	}


	public void setScore(int _Score)
	{
		Score = _Score;
	}
	*/
}

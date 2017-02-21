using UnityEngine;
using System.Collections;

public class CollectBall : MonoBehaviour {
	//public int	appleCount = 0;
	private ScoreManager scoremanager;

	void Start(){
		scoremanager = GetComponent<ScoreManager> ();
	}
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D apple) {
		if (apple.gameObject.tag == "apple") {
			//appleCount++;
			scoremanager.Score += 6;
		}
	}
	
	void OnTriggerExit2D(Collider2D apple)
	{
		if (apple.gameObject.tag == "apple") {
			//appleCount--;
			scoremanager.Score -= 6;
		}
	}
}

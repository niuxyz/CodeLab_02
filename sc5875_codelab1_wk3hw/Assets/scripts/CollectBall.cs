using UnityEngine;
using System.Collections;

public class CollectBall : MonoBehaviour {
	public int	appleCount = 0;


	// Use this for initialization
	void OnTriggerEnter2D (Collider2D apple) {
		if (apple.gameObject.tag == "apple") {
			appleCount++;
		}
	}
	
	void OnTriggerExit2D(Collider2D apple)
	{
		if (apple.gameObject.tag == "apple") {
			appleCount--;
		}
	}
}

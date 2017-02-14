using UnityEngine;
using System.Collections;

public class TriggerBox : MonoBehaviour {
	public Wk3GameManager sceneManager;
	public string SceneName;

	//when something enter the trigger zone
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.name == "Player") {
			sceneManager.loadAnotherScene (SceneName);
		}
	}

	/* //When something in the trigger zone
	void OnTriggerStay2D(Collider2D collider)
	{
		
	}
		//When something leave the trigger zone
	void OnTriggerExit2D(Collider2D collider)
	{
		
	}
	*/
}

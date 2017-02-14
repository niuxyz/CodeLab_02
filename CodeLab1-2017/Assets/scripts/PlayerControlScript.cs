using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour {

	public float speed = 1;
	public string horizontalInput;
	public string verticalInput;

	private bool changeColor = false;

	private SpriteRenderer sprite;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move();

		if(changeColor == true)
			ChangeColor ();

//		if(Input.GetKey(KeyCode.W)){
////			Debug.Log("This is working");
//			transform.Translate(Vector3.up * speed * Time.deltaTime);
//		}
//
//		if(Input.GetKey(KeyCode.S)){
//			transform.Translate(Vector3.down * speed * Time.deltaTime);
//		}
	}

	void Move(){
		//if(Input.GetKey(key)){
			//transform.Translate(dir * speed * Time.deltaTime);
			//rigid.velocity = (Vector2)dir * speed;
		//}

		float x = Input.GetAxis (horizontalInput);
		float y = Input.GetAxis (verticalInput);

		if (!changeColor && (x > 0 || y > 0))
			changeColor = true;

		rigid.velocity = new Vector2 (x, y) * speed;

		rigid.velocity *= 0.9f;
	}

	//Change the Color
	void ChangeColor()
	{
		sprite.color = new Color(sprite.color.r,sprite.color.g, sprite.color.b, rigid.velocity.magnitude*2);
	}
}

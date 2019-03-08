using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour {

	public Vector2 jump;
	public float jumpForce = 2.0f;

	public float playerSpeed;  //allows us to be able to change speed in Unity
	public Vector2 jumpHeight;

	void Start()
	{
	}

	void Update(){
		transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);  //makes player run

		if (Input.GetKeyDown(KeyCode.Space))  //makes player jump
			GetComponent<Rigidbody2D>().AddForce(jump * jumpForce, ForceMode2D.Impulse);
		}
	}
}
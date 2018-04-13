using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D player;
	public float speed = 5f;
	private float movementY = 0f;
	private float movementX = 0f;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		movementX = Input.GetAxis ("Horizontal");
		movementY = Input.GetAxis ("Vertical");

		if (movementX != 0 || movementY != 0) {
			//Debug.Log (movement);
			player.velocity = new Vector2 (movementX * speed, movementY * speed);
		}
		else {
			player.velocity = new Vector2 (0, 0);
		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

	public Rigidbody2D _rigidbody2D;
	public SpriteRenderer _spriteRenderer;
	public Canvas _canvas;
	public float playerSpeed;
	public float jumpPower;
	private int _directionInput;
	private bool isFacingRight = true;
	//private bool isOnGround = true;


	// Use this for initialization
	void Start ()
	{
		_rigidbody2D.GetComponent<Rigidbody2D> ();
		_spriteRenderer.GetComponent<SpriteRenderer> ();
		_canvas.GetComponent<Canvas> ();
	}



	void FixedUpdate()
	{
		_rigidbody2D.velocity = new Vector2 (playerSpeed * _directionInput, _rigidbody2D.velocity.y);
	}

	void MoveLeft()//Движение игрока налево
	{
		_directionInput = -1;
		if (isFacingRight)
			flip ();
	}
	void MoveRight()//Движение игрока направо 
	{
		_directionInput = 1;
		if (!isFacingRight)
			flip ();
	}
	void MoveStop()
	{
		_directionInput = 0;
	}

	void MoveJump()
	{
		_rigidbody2D.velocity = new Vector2 (_rigidbody2D.velocity.x, jumpPower);
	}


	void flip()
	{
		if(_spriteRenderer.flipX == true)
			_spriteRenderer.flipX = false;
		else
			_spriteRenderer.flipX = true;

		if (!_spriteRenderer.flipX)
			isFacingRight = true;
		else
			isFacingRight = false;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

  [SerializeField] Paddle paddle;
  [SerializeField] float xPush = 1f;
  [SerializeField] float yPush = 15f;
  Vector3 ballOffset;
  bool hasGameStarted = false;
  Rigidbody2D rigidbody2D;

  private void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
    ballOffset = transform.position - paddle.transform.position;

    rigidbody2D.bodyType = RigidbodyType2D.Kinematic;
  }

  // Update is called once per frame
  void Update () {
		if (hasGameStarted)
    {
      return;
    }

    LaunchOnMouseClick();
    LockBallToPaddle();
	}

  private void LaunchOnMouseClick()
  {
    if (Input.GetMouseButtonDown(1))
    {
      rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
      rigidbody2D.velocity = new Vector2(xPush, yPush);
      hasGameStarted = true;
    }
  }

  void LockBallToPaddle()
  {
    transform.position = new Vector3(paddle.transform.position.x, transform.position.y);
  }
}

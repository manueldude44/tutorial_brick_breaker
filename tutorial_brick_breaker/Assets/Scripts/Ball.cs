using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

  [SerializeField] Paddle paddle;
  [SerializeField] float xPush = 1f;
  [SerializeField] float yPush = 15f;
  [SerializeField] List<AudioClip> audioClips;

  AudioSource audioSource;
  Vector3 ballOffset;
  bool hasGameStarted = false;
  Rigidbody2D rigBody;

  private void Start()
  {
    rigBody = GetComponent<Rigidbody2D>();
    audioSource = GetComponent<AudioSource>();

    ballOffset = transform.position - paddle.transform.position;
    rigBody.bodyType = RigidbodyType2D.Kinematic;
  }

  // Update is called once per frame
  void Update()
  {
    if (hasGameStarted)
    {
      return;
    }

    LaunchOnMouseClick();
    LockBallToPaddle();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    audioSource.clip = GetRandomBallHitClip();
    audioSource.Play();
  }

  private void LaunchOnMouseClick()
  {
    if (Input.GetMouseButtonDown(1))
    {
      rigBody.bodyType = RigidbodyType2D.Dynamic;
      rigBody.velocity = new Vector2(xPush, yPush);
      hasGameStarted = true;
    }
  }

  void LockBallToPaddle()
  {
    transform.position = new Vector3(paddle.transform.position.x, transform.position.y);
  }

  AudioClip GetRandomBallHitClip()
  {
    return audioClips[Random.Range(0, audioClips.Count)];
  }
}

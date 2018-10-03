using UnityEngine;

public class Brick : MonoBehaviour
{

  [SerializeField] AudioClip onDestroySoundClip;

  GameSession gameStatus;
  Level level;

  private void Start()
  {
    gameStatus = FindObjectOfType<GameSession>();
    level = FindObjectOfType<Level>();
    level.AddBreakableBlock();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    gameStatus.UpdateScore();
    Destroy(gameObject);
    AudioSource.PlayClipAtPoint(onDestroySoundClip, new Vector3());
    level.RemoveBreakableBlock();
  }
}

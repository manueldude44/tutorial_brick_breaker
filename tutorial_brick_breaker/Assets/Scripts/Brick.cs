using UnityEngine;

public class Brick : MonoBehaviour
{
  [SerializeField] AudioClip onDestroySoundClip;

  private void OnCollisionEnter2D(Collision2D collision)
  {
    FindObjectOfType<GameSession>().UpdateScore();    
    AudioSource.PlayClipAtPoint(onDestroySoundClip, new Vector3());
    FindObjectOfType<Level>().RemoveBreakableBlock();

    Destroy(gameObject);
  }
}

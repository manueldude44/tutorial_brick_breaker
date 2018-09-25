using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

  [SerializeField] AudioClip onDestroySoundClip;

  private void OnCollisionEnter2D(Collision2D collision)
  {
    Destroy(gameObject);
    AudioSource.PlayClipAtPoint(onDestroySoundClip, new Vector3());
  }
}

using UnityEngine;

public class Level : MonoBehaviour
{
  int breakableBlocks = 0;
  SceneLoader sceneLoader;

  private void Awake()
  {
    breakableBlocks = FindObjectsOfType<Brick>().Length;
  }

  private void Start()
  {
    sceneLoader = FindObjectOfType<SceneLoader>();
  }

  public void RemoveBreakableBlock()
  {
    breakableBlocks--;

    if (breakableBlocks == 0)
    {
      sceneLoader.LoadNextScene();
    }
  }
}

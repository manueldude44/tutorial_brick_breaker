using UnityEngine;

public class Level : MonoBehaviour
{
  [SerializeField] int breakableBlocks = 0;

  SceneLoader sceneLoader;

  private void Start()
  {
    sceneLoader = FindObjectOfType<SceneLoader>();
  }

  public void AddBreakableBlock()
  {
    breakableBlocks++;
  }

  public void RemoveBreakableBlock()
  {
    breakableBlocks--;

    if (breakableBlocks == 0)
    {
      sceneLoader.LoadWinScene();
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void LoadNextScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void LoadStartScene()
  {
    SceneManager.LoadScene(0);
  }

  public void QuitGame()
  {
    Application.Quit();
  }

  public void LoadGameOver()
  {
    SceneManager.LoadScene("GameOver");
  }

  public void LoadWinScene()
  {
    SceneManager.LoadScene("Win");
  }

  public void LoadLevelOne()
  {
    SceneManager.LoadScene("Level1");
  }
}

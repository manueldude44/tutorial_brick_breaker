using TMPro;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI scoreUI;
  [SerializeField] int score = 0;

  const string SCORE_PREFIX = "Score: ";
  const int pointsPerBlock = 10;

  private void Awake()
  {
    if (FindObjectsOfType<GameSession>().Length > 1)
    {
      Destroy(gameObject);
    }
    else
    {
      DontDestroyOnLoad(gameObject);
    }

  }

  private void Start()
  {
    UpdateScoreText();
  }

  public void UpdateScore()
  {
    score += pointsPerBlock;
    UpdateScoreText();
  }

  public void UpdateScoreText()
  {
    scoreUI.text = SCORE_PREFIX + score.ToString();
  }

  public void ResetGame()
  {
    Destroy(gameObject);
  }
}

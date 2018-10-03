using TMPro;
using UnityEngine;

public class GameSession : MonoBehaviour
{
  [SerializeField] TextMeshProUGUI scoreUI;

  const string SCORE_PREFIX = "Score: ";
  const int pointsPerBlock = 10;
  
  int score = 0;

  private void Start()
  {
    scoreUI.text = score.ToString();
  }

  public void UpdateScore()
  {
    score += pointsPerBlock;
    scoreUI.text = score.ToString();
  }
}

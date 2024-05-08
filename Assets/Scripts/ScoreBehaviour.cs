using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBehaviour : MonoBehaviour
{
  [SerializeField] GameObject Player1Score;
  [SerializeField] GameObject Player2Score;
  float score1 = 0;
  float score2 = 0;

  [SerializeField]float GoalToWin;
  private void Update()
    {

    if (this.score1 >=this.GoalToWin || this.score2 >= this.GoalToWin)
    {
      Debug.Log("Game Won!");
      SceneManager.LoadScene("GameOver");
    }
      
    }
  private void FixedUpdate()
  {
    TextMeshProUGUI scorePlayer1=this.Player1Score.GetComponent<TextMeshProUGUI>();
    scorePlayer1.text =this.score1.ToString();
    TextMeshProUGUI scorePlayer2 = this.Player2Score.GetComponent<TextMeshProUGUI>();
    scorePlayer2.text =this.score2.ToString();  
  }

  public void GoalPlayer1()
  {
    this.score1++;

  }
  public void GoalPlayer2()
  {
    this.score2++;
  }
}



using UnityEngine;

public class BouncingOff : MonoBehaviour
{
  public BallMovment ballMovement;
  public ScoreBehaviour scoreController;

  void BounceFromRacket(Collision2D c)
  {

    Vector3 ballPosition = this.transform.position;
    Vector3 racketPosition = c.gameObject.transform.position;

    float racketHight = c.collider.bounds.size.y;

    float x;
    if (c.gameObject.name == "Racket1")
    {
      x = 1;
    }
    else
    {
      x = -1;
    }

    float y = (ballPosition.y - racketPosition.y) / racketHight;

    this.ballMovement.IncreaseHitCounter();
    this.ballMovement.MoveBall(new Vector2(x, y));

  }


  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
    {
      this.BounceFromRacket(collision);
    }
    else if (collision.gameObject.name == "LeftWall")
    {
      this.scoreController.GoalPlayer2();
      StartCoroutine(this.ballMovement.StartBall(true));
    }
    else if (collision.gameObject.name == "RightWall")
    {
      this.scoreController.GoalPlayer1();
      StartCoroutine(this.ballMovement.StartBall(false));
    }
  }

}

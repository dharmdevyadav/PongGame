using UnityEngine;

public class Racket2AI : MonoBehaviour
{
  public float moveSpeed;
  public GameObject ball;

  public void FixedUpdate()
  {
    if (Mathf.Abs(this.transform.position.y - ball.transform.position.y) > 1.09){
      if (transform.position.y < ball.transform.position.y)
      {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,1)*moveSpeed;
      }
      else
      {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;
      }
    }
    else
    {
      GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0) * moveSpeed;
    }
  }

}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovment : MonoBehaviour
{

  public float movementSpeed;
  public float extraSpeedPerHit;
  public float maxExtraSpeed;
  private float MinusXBound = -8.98f;
  private float XBound = 8.89f;
  private float MinusyBound = -4.18f;
  private float YBound = 5.24f;

  int hitCounter = 0;


  // Use this for initialization
  void Start()
  {
    StartCoroutine(this.StartBall());
  }


  void PositionBall(bool isStartingPlayer1)
  {
    
    this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

    if (isStartingPlayer1)
    {
      this.gameObject.transform.localPosition = new Vector3(-1.4f, 0, 0);
    }
    else
    {
      this.gameObject.transform.localPosition = new Vector3(1.4f, 0, 0);
    }

  }


  public IEnumerator StartBall(bool isStartingPlayer1 = true)
  {

    this.PositionBall(isStartingPlayer1);
    
    this.hitCounter = 0;
    yield return new WaitForSeconds(2);
    if (isStartingPlayer1)
      this.MoveBall(new Vector2(-1, 0));
    else
    {
      this.MoveBall(new Vector2(1, 0));
    }

  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
    if (rigidBody2D.transform.position.x < MinusXBound || rigidBody2D.transform.position.x > XBound
      || rigidBody2D.transform.position.y < MinusyBound || rigidBody2D.transform.position.y > YBound)
    {
      Destroy(this.gameObject);
      DontDestroyOnLoad(this.gameObject);
      SceneManager.LoadScene("Game");

    }
  }
  public void MoveBall(Vector2 dir)
  {

    dir = dir.normalized;

    float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

    Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

    rigidBody2D.velocity = dir * speed;
    if (rigidBody2D.transform.position.x < MinusXBound || rigidBody2D.transform.position.x > XBound 
      || rigidBody2D.transform.position.y < MinusyBound || rigidBody2D.transform.position.y > YBound)
    {
      Destroy(this.gameObject);
      DontDestroyOnLoad(this.gameObject);
      SceneManager.LoadScene("Game");
      
    }
  }


  public void IncreaseHitCounter()
  {
    if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
    {
      this.hitCounter++;
    }
  }

}

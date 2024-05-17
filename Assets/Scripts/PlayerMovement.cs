using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  Rigidbody2D rb;
  
  
  [SerializeField] float moveSpeed;

  private void Start()
  {
    rb=GetComponent<Rigidbody2D>();
  }
  private void FixedUpdate()
  {
    float moveY = Input.GetAxisRaw("Vertical");
    rb.velocity = new Vector2(0, moveY) * moveSpeed*Time.deltaTime;

  }

}

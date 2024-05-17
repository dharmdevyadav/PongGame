using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
  Rigidbody2D rb;
  [SerializeField] float moveSpeed;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }
  private void FixedUpdate()
  {
    float moveY = Input.GetAxisRaw("Vertical2");
    rb.velocity = new Vector2(0, moveY) * moveSpeed;

  }
}

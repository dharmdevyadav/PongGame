using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  [SerializeField] AudioSource hitEffect;

  void Start()
  {
    hitEffect = GetComponent<AudioSource>();
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if(hitEffect != null)
    {
      hitEffect.Play();
    }
  }
}

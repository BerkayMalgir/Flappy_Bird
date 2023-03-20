using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
   public Rigidbody2D rigidbody;
   public float flapStrength;
   public LogicScript logic;
   public bool birdIsAlive = true;

   private void Start()
   {
      logic = GameObject.FindGameObjectWithTag("Logic")?.GetComponent<LogicScript>();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
      {
         rigidbody.velocity = Vector2.up * flapStrength;
      }
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      logic.GameOver();
      birdIsAlive = false;
   }
}

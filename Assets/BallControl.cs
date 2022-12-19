using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int playerScore;
    public int computerScore;
    public Rigidbody rb;
    public float movespeed = 100f;
    public Vector3 initialImpulse;

    public Vector3 BallResetHumanGoal;
    public Vector3 BallResetCompGoal;  

    void OnCollisionEnter(Collision collision){

      if (collision.transform.name == "ComputerGoal") {
        Scoreboard.PlayerScore += 1;
        transform.position = BallResetHumanGoal;
        rb.AddForce(initialImpulse, ForceMode.Impulse);
        
      }
      if (collision.transform.name == "PlayerGoal") {
        Scoreboard.PlayerScore -=1;
        transform.position = BallResetCompGoal;
        rb.AddForce(initialImpulse, ForceMode.Impulse);
      }
    }

    // Start is called before the first frame update
    void Start()
    {
      rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}

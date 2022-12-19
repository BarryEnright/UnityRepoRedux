using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerPlayerBlue : MonoBehaviour 
{
	
	public float speed = 60f;

	private Rigidbody rb;
	
	public Transform ball;


	void Start()
	{
		rb = GetComponent<Rigidbody>();
		ball = GameObject.FindWithTag("Ball").transform;
	}
	
	
	void Update () 
	{
		if (ball.position.x < transform.position.x)
		{
			rb.velocity = Vector3.left * speed;
		}
		else if (ball.position.x > transform.position.x)
		{
			rb.velocity = Vector3.right * speed;
		}
		else
		{
			rb.velocity = Vector3.zero;
		}
	}
}

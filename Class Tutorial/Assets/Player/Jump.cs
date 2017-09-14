using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
	CharacterController Player;
	public float jumpPower;
	private Vector3 jump = Vector3.zero;
	public float Gravity;
	// Use this for initialization
	void Start () 
	{
		Player = gameObject.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Player.isGrounded) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				jump.y = jumpPower;
			}
		}

		jump.y -= Gravity * Time.deltaTime;
		Player.Move (jump * Time.deltaTime);
	}
}
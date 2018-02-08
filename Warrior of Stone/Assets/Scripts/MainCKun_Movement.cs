using UnityEngine;
using System.Collections;

public class MainCKun_Movement : MonoBehaviour {

	private Rigidbody2D mCharEngine;
	private Vector3 tempVelocity;

	public float maxXVelocity;

	// Use this for initialization
	void Start () 
	{
		mCharEngine = gameObject.GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		tempVelocity = mCharEngine.velocity;

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			//print("up arrow key is held down");

			//This will be for climbing ladders and stuff
		}

		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			//print("down arrow key is held down");

			//this will be or ducking and ladders and stuff
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			//print("left arrow key is held down");

			tempVelocity.x -= 2;
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			//print("right arrow key is held down");

			tempVelocity.x += 2;
		}

		if (Input.GetKey (KeyCode.W)) 
		{
			//print("w key is held down");

			//This will be for climbing ladders and stuff
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			//print("s key is held down");

			//this will be or ducking and ladders and stuff
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			//print("a key is held down");

			tempVelocity.x -= 2;
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			//print("d key is held down");

			tempVelocity.x += 2;
		}

		if (Input.GetKey (KeyCode.Space)) 
		{
			//print("space bar is held down");

			//add some small gravity decrease for longer jumping on hold?

			if (true) //not jumping
			{ 
				tempVelocity.y = 15;
			}
		}

		if (tempVelocity.x > maxXVelocity) 
		{
			tempVelocity.x = maxXVelocity;
		} 
		else if (tempVelocity.x < (-1) * maxXVelocity) 
		{
			tempVelocity.x = (-1) * maxXVelocity;
		}  

		mCharEngine.velocity = tempVelocity;
	}
}

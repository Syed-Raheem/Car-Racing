using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
public KeyCode MoveForward;
public KeyCode MoveBackward;
public KeyCode MoveLeft;
public KeyCode MoveRight;
public float speed=10f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(MoveForward))                              //Checking whether the player is pressing the moveforward key
		transform.Translate(Vector3.forward*speed*Time.deltaTime); //If player has pressed the move forward key then we are moving the player forward
		if(Input.GetKey(MoveBackward))                             //Checking whether the player is pressing the movebackward key
		transform.Translate(-Vector3.forward*speed*Time.deltaTime);//If player has pressed the move backward key then we are moving the player backward
		if(Input.GetKey(MoveLeft))                                 //Checking whether the player is pressing the moveleft key
		transform.Translate(-Vector3.right*speed*Time.deltaTime);  //If player has pressed the move left key then we are moving the player left
		if(Input.GetKey(MoveRight))                                //Checking whether the player is pressing the moveright key
		transform.Translate(Vector3.right*speed*Time.deltaTime);   //If player has pressed the move right key then we are moving the player right
	}
}
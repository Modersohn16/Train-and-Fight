using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
    public Animator anim;
    public Joystick joystick;
    public float MoveX = 0;
    
   
    public float MoveFloat = 0f;


	public float runSpeed = 40f;

	float horizontalMove = 0f;
	public bool jump = false;
	bool crouch = false;
	
	// Update is called once per frame
	void Update () {

        // This is alternative movement using two buttons

 MoveX = CrossPlatformInputManager.GetAxis ("Horizontal");
horizontalMove = MoveX * runSpeed;
anim.SetFloat("speed", Mathf.Abs(horizontalMove));



        // This is movement script for PC

        /* horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
           anim.SetFloat("speed", Mathf.Abs(horizontalMove)); */


        // This is the actual movement script for mobile

        /*  if (joystick.Horizontal >= 0)
        {
            horizontalMove = Mathf.Ceil(joystick.Horizontal) * runSpeed;

            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        } else
        {
            horizontalMove = Mathf.Floor(joystick.Horizontal) * runSpeed;

            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        }

            */


        // if (Input.GetButtonDown("Jump"))

        if (Input.GetButtonDown("Jump"))
{

    jump = true;
    anim.SetTrigger("HeroJump");

}

if (Input.GetButtonDown("Crouch"))
{
    crouch = true;
} else if (Input.GetButtonUp("Crouch"))
{
    crouch = false;
}

}

void FixedUpdate ()
{
// Move our character
controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
jump = false;
}
}

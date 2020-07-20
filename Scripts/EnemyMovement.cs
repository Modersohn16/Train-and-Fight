using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class EnemyMovement : MonoBehaviour
{
    public GameObject MyEnemy;
    private CharacterController2D controller;
    public Animator anim;
    public Joystick joystick;
    public float MoveX = 0;


    public float MoveFloat = 0f;


    public float runSpeed = 40f;

    float horizontalMove = 0f;
    public bool jump = false;
    bool crouch = false;

   void Start()
    {

      controller = MyEnemy.GetComponent<CharacterController2D>();

    } 

    // Update is called once per frame
    void Update()
    {

        // This is alternative movement using two buttons

        /*  MoveX = CrossPlatformInputManager.GetAxis ("Horizontal");
        horizontalMove = MoveX * runSpeed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        */

        if (Input.GetButtonDown("ZombieRight"))
        {
            MoveX = 1;
        }
        if (Input.GetButtonUp("ZombieRight"))
        {
            MoveX = 0;
        }

        if (Input.GetButtonDown("ZombieLeft"))
        {
            MoveX = -1;
        }
        if (Input.GetButtonUp("ZombieLeft"))
        {
            MoveX = 0;
        }
        // This is movement script for PC

        horizontalMove = MoveX * runSpeed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));


        // This is the actual movement script for mobile

        /* if (joystick.Horizontal >= 0)
        {
            horizontalMove = Mathf.Ceil(joystick.Horizontal) * runSpeed;
            
            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        } else
        {
            horizontalMove = Mathf.Floor(joystick.Horizontal) * runSpeed;
            
            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        }
        
     */


        

        if (Input.GetButtonDown("ZombieJump"))
        {

            jump = true;
            anim.SetTrigger("HeroJump");

        }

        if (Input.GetButtonDown("ZombieCrouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("ZombieCrouch"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}



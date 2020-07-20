using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject MyEnemy;
    public CharacterController2D controller;
    public float lookRadius = 10f;
    public float stopDistance = 2f;
    private float horizontalMove;
    public Animator anim;
    


    public bool jump = false;
    bool crouch = false;


    public float MySpeed = 10f;
    

    Transform target;

    void Start()
    {
        target = PlayerManager.instance.player.transform;
        
            controller = MyEnemy.GetComponent<CharacterController2D>();
       
        
    }

    void Update()
    {
        float distance = Vector2.Distance(target.position, transform.position);



        if (distance <= lookRadius && target.position.x > transform.position.x && distance > stopDistance)
        {
            horizontalMove = 1f * MySpeed;
            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        }
        else
        {
            horizontalMove = 0f;
        }

        if (distance <= lookRadius && target.position.x < transform.position.x && distance > stopDistance)
        {
            horizontalMove = -1f * MySpeed;
            anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        }
        else
        {
            horizontalMove = 0f;
        }
        //  if (distance < stoppingDistance){ 
        // 

    }

    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, stopDistance);
    }

    
   
}

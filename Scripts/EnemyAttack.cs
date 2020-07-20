using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class EnemyAttack : MonoBehaviour {


    public float AttackRadius = 3f;
    CharacterStats targetStats;
    public Animator anim;
    
    Transform target;

    
    

    void Start()
    {
        target = PlayerManager.instance.player.transform;
       
    }
    

    // Update is called once per frame
    void Update () {
        float distance = Vector2.Distance(target.position, transform.position);
        CharacterCombat enemyCombat = GetComponent<CharacterCombat>();


       if (distance <= AttackRadius)
        {

            CharacterStats targetStats = target.GetComponent<CharacterStats>();
            if (targetStats != null) {
                anim.SetBool("isAttacking", true);
            enemyCombat.Attack(targetStats);
             
            }
        } else
        {
            anim.SetBool("isAttacking", false);
        } 
    }
    

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, AttackRadius);
    }
}

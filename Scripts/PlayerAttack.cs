using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterStats))]
public class PlayerAttack : MonoBehaviour {


    public CharacterStats myStats;
    public Transform attackPos;
    public LayerMask whatisEnemies;

    public float AttackRadius = 3f;
    public Animator anim;
        
    Transform target;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("atak"))
        {
            Atak();

        }


        
        
    }
    public void Atak()
    {
        anim.SetTrigger("Attack");
        Debug.Log("ATAAAK");
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, AttackRadius, whatisEnemies);
        for (int i = 0; i < enemiesToDamage.Length; i++)
        {
            enemiesToDamage[i].GetComponent<CharacterStats>().TakeDamage(myStats.TotalDamage);

        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, AttackRadius);
    }
}

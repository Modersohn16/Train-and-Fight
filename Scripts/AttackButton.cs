using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour {

    public GameObject player;
    public PlayerAttack playerAttack;

    void Start()
    {
        playerAttack = player.GetComponent<PlayerAttack>();
    }
    
    public void OnButtonAttack()
    {
        playerAttack.Atak();
      
    }


}

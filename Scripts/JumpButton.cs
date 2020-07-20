using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour {

  

        public PlayerMovement player;
    

    
    public void onButtonjump()
    {
        player.jump = true;
    }

}
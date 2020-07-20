using UnityEngine;


public class PlayerCharacterStats : CharacterStats {


    public override void Awake () {

        
        Strength = PlayerPrefs.GetFloat("CurrentSTRlevel"); // LOAD
        base.Awake();
    }


   public override void TakeDamage(float TotalDamage)
    {
       
        base.TakeDamage(TotalDamage);
    }
    

}

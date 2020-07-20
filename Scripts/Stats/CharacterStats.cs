using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour {

    public float Basedamage = 0;
    public float armor = 0;
    public Animator anim;

    public float maxHealth = 100;
    public float currentHealth { get; private set; }
    public float Strength = 0;

    public float TotalDamage;
    public Image healthBar;

    public virtual void Awake()
    {
        
        currentHealth = maxHealth;
        
        TotalDamage = Basedamage + Strength;
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        } 
    }

    public virtual void TakeDamage (float TotalDamage)
    {
        
        TotalDamage -= armor;
        
        TotalDamage = Mathf.Clamp(TotalDamage, 0, float.MaxValue);

        currentHealth -= TotalDamage;
        Debug.Log(transform.name + " takes " + TotalDamage + " damage.");

        healthBar.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            anim.SetBool("DieBool", true);

            Die();
        }
    }

    public virtual void Die ()
    {
        // Die in some way
        // This method is meant to be overwritten

        Debug.Log(transform.name + " Died.");
    }

}

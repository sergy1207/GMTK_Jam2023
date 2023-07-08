using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] LifeBarController healthBar;
    [SerializeField] int maxHealth;
    public int MaxHealth
    {
        get{ return maxHealth;}
        set{maxHealth = value;}
    }
    int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///<summary>
    /// Resta a la cantidad actual de vida el numero de dano indicado
    ///</summary>
    public void GetDamage(int damage)
    {
        health -=damage;
        healthBar.UpdateLifeBar(health, maxHealth);
    }

    ///<summary>
    /// Suma a la cantidad actual de vida el numero de salud indicado
    ///</summary>
    public void Heal(int health)
    {
        health += health;
        healthBar.UpdateLifeBar(health, maxHealth);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount, Pawn source)
    {
        currentHealth -= amount;
        Debug.Log(source.name + "did " + amount + "damage to the " + gameObject.name);

        if (currentHealth <= 0) 
        {
            Die(source); //parameter
        }
    }

    public void ReplenishHealth(float amount, Pawn source) 
    { 
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void Die(Pawn source) //val passed
    {
        Destroy(gameObject);
        Debug.Log(source.name + " brutally murdered " + gameObject.name);
    }
}

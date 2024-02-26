using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageDone;
    public Pawn owner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //get health component from colliding obj
        Health otherHealth = other.gameObject.GetComponent<Health>();

        if (otherHealth != null) 
        {
            //do damage
            otherHealth.TakeDamage(damageDone, owner);
        }

        //Destroy obj
        Destroy(gameObject);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SnakeTrigger : MonoBehaviour
{
    public float maxHealth = 10f;
    public float currentHealth;
    // on door trigger box collider2d
    // set anim to have player proximity 
    // after timer set anim to have player proximity again
    //
     public Animator anim;
     public string triggerTag = "Player";
     public string currentState= "Submerged";

     public float lifetime;//the randomized value 
    //private float fireTimer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }


    public void TakeDamage(float damageAmount)
    {
        if(currentState== "Risen")
        {
        currentHealth -= damageAmount;

        if (currentHealth <= 0f)
        {
            Die();
        }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
     {
        //print("collission");
         if (other.CompareTag(triggerTag))
             //print ("collissionplayer");
             currentState="risen";
             anim.SetTrigger("PlayerProximity");
             SnakeAlive();
    }

    void SnakeAlive()
    {

         lifetime=UnityEngine.Random.Range(10f, 30f);
         lifetime -= Time.deltaTime;

            if (lifetime <= 0f)
            {
                anim.SetTrigger("PlayerProximity");
                currentState="submerged";
                SnakeAsleep();
            }    
    }

   void SnakeAsleep()
    {

         lifetime=UnityEngine.Random.Range(10f, 20f);
         lifetime -= Time.deltaTime;

            if (lifetime <= 0f)
            {
                anim.SetTrigger("PlayerProximity");
                currentState="risen";
                SnakeAlive();
            }    
    }

    // start running snake randomness so it is running a timer set to a randomized number
    // and looping through risen and submerged 




    // private void OnTriggerExit2D(Collider2D other)
    // {
    //      //print ("left");
    //      if (other.CompareTag(triggerTag))
    //          //print ("playerleft");
    //          anim.SetTrigger("PlayerProximity");
    //     }

    void Die()
    {
        Destroy(gameObject);
    }
}

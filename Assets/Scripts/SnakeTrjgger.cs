using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SnakeTrigger : MonoBehaviour
{
    // on door trigger box collider2d
    // set anim to have player proximity 
    // after timer set anim to have player proximity again
    //
     public Animator anim;
     public string triggerTag = "Player";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D other)

    {
        print("collission");
         if (other.CompareTag(triggerTag))
             print ("collissionplayer");
             anim.SetTrigger("PlayerProximity");
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
         print ("left");
         if (other.CompareTag(triggerTag))
             print ("playerleft");
             anim.SetTrigger("PlayerProximity");


    
        }

}

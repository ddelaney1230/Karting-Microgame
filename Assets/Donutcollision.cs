using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donutcollision : MonoBehaviour
{
   public AudioSource ImpactSound;
   
   void OnCollisionEnter(Collision collision)
   {
    if (collision.relativeVelocity.magnitude > 1)
        {
            ImpactSound.Play();
        }
            
    }
   
   
   
}

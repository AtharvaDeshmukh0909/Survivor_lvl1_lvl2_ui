using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFrame_2 : MonoBehaviour
{
    public Bird_2 bird;
    public Transform t_Bird;

   void OnTriggerEnter (Collider other)
   {
       if(other.transform==t_Bird)
        {
            bird.rightFrame=true;
        }
    }
}

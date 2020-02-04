using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthsystem : MonoBehaviour
{

    public Slider healthBar;

    public  void Damage(int damgeValue)
    {
        healthBar.value= healthBar.value - damgeValue;
    }
     void Update()
    {
        if(healthBar.value<=0)
        {
            // death mode activated here 
        }
        
    }
}

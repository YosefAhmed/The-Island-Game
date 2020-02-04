using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damgeing : MonoBehaviour
{
    public int damgevalue;
    public GameObject HS;

     void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            HS.GetComponent<healthsystem>().Damage(damgevalue);
        }
        
    }
}
